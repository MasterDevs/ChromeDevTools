using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Starts (or continues) consecutive canvas frames capturing. The capturing is stopped by the corresponding stopCapturing command.
	/// </summary>
	[Command(ProtocolName.Canvas.StartCapturing)]
	public class StartCapturingCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose canvases are to be captured. If omitted, main frame is assumed.
		/// </summary>
		public string FrameId { get; set; }
	}
}
