using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Fired when frame has been detached from its parent.
	/// </summary>
	[Event(ProtocolName.Page.FrameDetached)]
	[SupportedBy("iOS")]
	public class FrameDetachedEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has been detached.
		/// </summary>
		public string FrameId { get; set; }
	}
}
