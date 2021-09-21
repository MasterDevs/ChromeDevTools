using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
	/// web font
	/// </summary>
	[Event(ProtocolName.CSS.FontsUpdated)]
	[SupportedBy("Chrome")]
	public class FontsUpdatedEvent
	{
		/// <summary>
		/// Gets or sets The web font that has loaded.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FontFace Font { get; set; }
	}
}
