using ChromeDevTools;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame has been attached to its parent.
	/// </summary>
	[Event(ProtocolName.Page.FrameAttached)]
	public class FrameAttachedEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has been attached.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Parent frame identifier.
		/// </summary>
		public string ParentFrameId { get; set; }
	}
}
