using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Deprecated, please use addScriptToEvaluateOnNewDocument instead.
	/// </summary>
	[Obsolete("Deprecated, please use addScriptToEvaluateOnNewDocument instead.")]
	[Command(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	[SupportedBy("Chrome")]
	public class AddScriptToEvaluateOnLoadCommand: ICommand<AddScriptToEvaluateOnLoadCommandResponse>
	{
		/// <summary>
		/// Gets or sets ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
