using ChromeDevTools;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame has been detached from its parent.
	/// </summary>
	[Event(ProtocolName.Page.FrameDetached)]
	public class FrameDetachedEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has been detached.
		/// </summary>
		public string FrameId { get; set; }
	}
}
