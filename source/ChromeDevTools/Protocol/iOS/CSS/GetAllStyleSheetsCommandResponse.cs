using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns metainfo entries for all known stylesheets.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetAllStyleSheets)]
	[SupportedBy("iOS")]
	public class GetAllStyleSheetsCommandResponse
	{
		/// <summary>
		/// Gets or sets Descriptor entries for all available stylesheets.
		/// </summary>
		public CSSStyleSheetHeader[] Headers { get; set; }
	}
}
