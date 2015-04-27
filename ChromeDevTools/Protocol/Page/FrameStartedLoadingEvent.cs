using ChromeDevTools;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame has started loading.
	/// </summary>
	[Event(ProtocolName.Page.FrameStartedLoading)]
	public class FrameStartedLoadingEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has started loading.
		/// </summary>
		public string FrameId { get; set; }
	}
}
