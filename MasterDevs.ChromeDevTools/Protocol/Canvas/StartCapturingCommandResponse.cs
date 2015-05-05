using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Starts (or continues) consecutive canvas frames capturing. The capturing is stopped by the corresponding stopCapturing command.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.StartCapturing)]
	public class StartCapturingCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the trace log containing captured canvas calls.
		/// </summary>
		public string TraceLogId { get; set; }
	}
}
