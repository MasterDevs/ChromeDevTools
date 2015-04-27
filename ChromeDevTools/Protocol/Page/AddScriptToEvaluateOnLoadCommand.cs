using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
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
