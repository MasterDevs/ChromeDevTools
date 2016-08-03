using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	[CommandResponse(ProtocolName.Canvas.ReplayTraceLog)]
	[SupportedBy("Chrome")]
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
