using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[Command(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	[SupportedBy("iOS")]
	public class AddScriptToEvaluateOnLoadCommand: ICommand<AddScriptToEvaluateOnLoadCommandResponse>
	{
		/// <summary>
		/// Gets or sets ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
