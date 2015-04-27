using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	[Command(ProtocolName.Canvas.StopCapturing)]
	public class StopCapturingCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		public string TraceLogId { get; set; }
	}
}
