using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	/// <summary>
	/// Starts (or continues) a canvas frame capturing which will be stopped automatically after the next frame is prepared.
	/// </summary>
	[Command(ProtocolName.Canvas.CaptureFrame)]
	[SupportedBy("Chrome")]
	public class CaptureFrameCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose canvases are to be captured. If omitted, main frame is assumed.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
