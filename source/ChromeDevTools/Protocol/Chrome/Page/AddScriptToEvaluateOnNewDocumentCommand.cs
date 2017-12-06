using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Evaluates given script in every frame upon creation (before loading frame's scripts).
	/// </summary>
	[Command(ProtocolName.Page.AddScriptToEvaluateOnNewDocument)]
	[SupportedBy("Chrome")]
	public class AddScriptToEvaluateOnNewDocumentCommand: ICommand<AddScriptToEvaluateOnNewDocumentCommandResponse>
	{
		/// <summary>
		/// Gets or sets Source
		/// </summary>
		public string Source { get; set; }
	}
}
