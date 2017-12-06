using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetStyleSheetText)]
	[SupportedBy("Chrome")]
	public class SetStyleSheetTextCommandResponse
	{
		/// <summary>
		/// Gets or sets URL of source map associated with script (if any).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceMapURL { get; set; }
	}
}
