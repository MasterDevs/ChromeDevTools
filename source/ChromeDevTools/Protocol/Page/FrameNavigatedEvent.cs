using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
	/// </summary>
	[Event(ProtocolName.Page.FrameNavigated)]
	public class FrameNavigatedEvent
	{
		/// <summary>
		/// Gets or sets Frame object.
		/// </summary>
		public Frame Frame { get; set; }
	}
}
