using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Fired whenever a stylesheet is changed as a result of the client operation.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetChanged)]
	[SupportedBy("iOS")]
	public class StyleSheetChangedEvent
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
