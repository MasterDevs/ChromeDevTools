using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Acknowledges that a screencast frame has been received by the frontend.
	/// </summary>
	[Command(ProtocolName.Page.ScreencastFrameAck)]
	public class ScreencastFrameAckCommand
	{
		/// <summary>
		/// Gets or sets Frame number.
		/// </summary>
		public long FrameNumber { get; set; }
	}
}
