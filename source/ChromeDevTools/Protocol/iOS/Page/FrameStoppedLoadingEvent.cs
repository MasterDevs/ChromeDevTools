using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Fired when frame has stopped loading.
	/// </summary>
	[Event(ProtocolName.Page.FrameStoppedLoading)]
	[SupportedBy("iOS")]
	public class FrameStoppedLoadingEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has stopped loading.
		/// </summary>
		public string FrameId { get; set; }
	}
}
