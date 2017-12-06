using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Evaluates given script in every frame upon creation (before loading frame's scripts).
	/// </summary>
	[CommandResponse(ProtocolName.Page.AddScriptToEvaluateOnNewDocument)]
	[SupportedBy("Chrome")]
	public class AddScriptToEvaluateOnNewDocumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the added script.
		/// </summary>
		public string Identifier { get; set; }
	}
}
