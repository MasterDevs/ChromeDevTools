using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Threading;
using WebSocket4Net;

namespace AutoWebPerf
{
    /// <summary>
    /// ABPS: https://markcz.wordpress.com/2012/02/18/automating-chrome-browser-from-csharp/
    /// </summary>
    public class ChromeWrapper
    {
        const string JsonPostfix = "/json";

        string remoteDebuggingUri;
        string sessionWSEndpoint;

        public ChromeWrapper(string remoteDebuggingUri)
        {
            this.remoteDebuggingUri = remoteDebuggingUri;
        }

        public TRes SendRequest<TRes>()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(remoteDebuggingUri + JsonPostfix);
            var resp = req.GetResponse();
            var respStream = resp.GetResponseStream();

            StreamReader sr = new StreamReader(respStream);
            var s = sr.ReadToEnd();
            resp.Dispose();
            return Deserialise<TRes>(s);
        }

        public List<RemoteSessionsResponse> GetAvailableSessions()
        {
            var res = this.SendRequest<List<RemoteSessionsResponse>>();
            return (from r in res
                    where r.devtoolsFrontendUrl != null
                    select r).ToList();
        }

        public string NavigateTo(string uri)
        {
            // Page.navigate is working from M18
            var json = @"{""method"":""Page.navigate"",""params"":{""url"":""" + uri + @"""},""id"":1}";

            // Instead of Page.navigate, we can use document.location
            //var json = @"{""method"":""Runtime.evaluate"",""params"":{""expression"":""document.location='" + uri + @"'"",""objectGroup"":""console"",""includeCommandLineAPI"":true,""doNotPauseOnExceptions"":false,""returnByValue"":false},""id"":1}";
            return this.SendCommand(json);
        }

        public string GetElementsByTagName(string tagName)
        {
            // Page.navigate is working from M18
            //var json = @"{""method"":""Page.navigate"",""params"":{""url"":""http://www.seznam.cz""},""id"":1}";

            // Instead of Page.navigate, we can use document.location
            var json = @"{""method"":""Runtime.evaluate"",""params"":{""expression"":""document.getElementsByTagName('" + tagName + @"')"",""objectGroup"":""console"",""includeCommandLineAPI"":true,""doNotPauseOnExceptions"":false,""returnByValue"":false},""id"":1}";
            return this.SendCommand(json);
        }


        public string Eval(string cmd)
        {
            var json = @"{""method"":""Runtime.evaluate"",""params"":{""expression"":""" + cmd + @""",""objectGroup"":""console"",""includeCommandLineAPI"":true,""doNotPauseOnExceptions"":false,""returnByValue"":false},""id"":1}";
            return this.SendCommand(json);
        }

        public string SendCommand(string cmd)
        {
            WebSocket4Net.WebSocket j = new WebSocket4Net.WebSocket(this.sessionWSEndpoint);
            ManualResetEvent waitEvent = new ManualResetEvent(false);
            ManualResetEvent closedEvent = new ManualResetEvent(false);
            string message = "";
            byte[] data;

            Exception exc = null;
            j.Opened += delegate(System.Object o, EventArgs e)
            {
                j.Send(cmd);
            };

            j.MessageReceived += delegate(System.Object o, MessageReceivedEventArgs e)
            {
                message = e.Message;
                waitEvent.Set();
            };

            j.Error += delegate(System.Object o, SuperSocket.ClientEngine.ErrorEventArgs e)
            {
                exc = e.Exception;
                waitEvent.Set();
            };

            j.Closed += delegate(System.Object o, EventArgs e)
            {
                closedEvent.Set();
            };

            j.DataReceived += delegate(System.Object o, DataReceivedEventArgs e)
            {
                data = e.Data;
                waitEvent.Set();
            };

            j.Open();

            waitEvent.WaitOne();
            if (j.State == WebSocket4Net.WebSocketState.Open)
            {
                j.Close();
                closedEvent.WaitOne();
            }
            if (exc != null)
                throw exc;

            return message;
        }

        private T Deserialise<T>(string json)
        {

            T obj = Activator.CreateInstance<T>();
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                obj = (T)serializer.ReadObject(ms);
                return obj;
            }
        }

        private T Deserialise<T>(Stream json)
        {
            T obj = Activator.CreateInstance<T>();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(json);
            return obj;
        }

        public void SetActiveSession(string sessionWSEndpoint)
        {
            // Sometimes binding to localhost might resolve wrong AddressFamily, force IPv4
            this.sessionWSEndpoint = sessionWSEndpoint.Replace("ws://localhost", "ws://127.0.0.1");

        }
    }
}