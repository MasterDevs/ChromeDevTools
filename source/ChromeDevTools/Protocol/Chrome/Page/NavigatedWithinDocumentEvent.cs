using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when same-document navigation happens, e.g. due to history API usage or anchor navigation.
	/// </summary>
	[Event(ProtocolName.Page.NavigatedWithinDocument)]
	[SupportedBy("Chrome")]
	public class NavigatedWithinDocumentEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Frame's new url.
		/// </summary>
		public string Url { get; set; }
	}
}
