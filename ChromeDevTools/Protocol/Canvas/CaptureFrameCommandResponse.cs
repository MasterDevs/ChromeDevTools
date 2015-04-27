using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Starts (or continues) a canvas frame capturing which will be stopped automatically after the next frame is prepared.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.CaptureFrame)]
	public class CaptureFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the trace log containing captured canvas calls.
		/// </summary>
		public string TraceLogId { get; set; }
	}
}
