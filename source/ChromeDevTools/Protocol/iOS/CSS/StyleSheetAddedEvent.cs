using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is added.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetAdded)]
	[SupportedBy("iOS")]
	public class StyleSheetAddedEvent
	{
		/// <summary>
		/// Gets or sets Added stylesheet metainfo.
		/// </summary>
		public CSSStyleSheetHeader Header { get; set; }
	}
}
