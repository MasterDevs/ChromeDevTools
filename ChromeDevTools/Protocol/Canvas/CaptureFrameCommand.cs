using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Starts (or continues) a canvas frame capturing which will be stopped automatically after the next frame is prepared.
	/// </summary>
	[Command(ProtocolName.Canvas.CaptureFrame)]
	public class CaptureFrameCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose canvases are to be captured. If omitted, main frame is assumed.
		/// </summary>
		public string FrameId { get; set; }
	}
}
