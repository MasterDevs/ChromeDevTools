using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	[CommandResponse(ProtocolName.Canvas.ReplayTraceLog)]
	public class ReplayTraceLogCommandResponse
	{
		/// <summary>
		/// Gets or sets ResourceState
		/// </summary>
		public ResourceState ResourceState { get; set; }
		/// <summary>
		/// Gets or sets Replay time (in milliseconds).
		/// </summary>
		public double ReplayTime { get; set; }
	}
}
