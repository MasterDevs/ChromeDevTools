using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is removed.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetRemoved)]
	[SupportedBy("iOS")]
	public class StyleSheetRemovedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the removed stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
