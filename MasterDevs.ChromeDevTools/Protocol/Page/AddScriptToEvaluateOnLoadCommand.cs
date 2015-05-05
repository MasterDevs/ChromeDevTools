using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	[Command(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	public class AddScriptToEvaluateOnLoadCommand
	{
		/// <summary>
		/// Gets or sets ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
