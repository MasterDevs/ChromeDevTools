using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Compressed image data requested by the <code>startScreencast</code>.
	/// </summary>
	[Event(ProtocolName.Page.ScreencastFrame)]
	public class ScreencastFrameEvent
	{
		/// <summary>
		/// Gets or sets Base64-encoded compressed image.
		/// </summary>
		public string Data { get; set; }
		/// <summary>
		/// Gets or sets Screencast frame metadata.
		/// </summary>
		public ScreencastFrameMetadata Metadata { get; set; }
		/// <summary>
		/// Gets or sets Frame number.
		/// </summary>
		public long FrameNumber { get; set; }
	}
}
