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
	[CommandResponse(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	[SupportedBy("Chrome")]
	public class AddScriptToEvaluateOnLoadCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the added script.
		/// </summary>
		public string Identifier { get; set; }
	}
}
