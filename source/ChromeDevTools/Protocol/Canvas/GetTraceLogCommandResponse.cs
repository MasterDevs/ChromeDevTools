using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[CommandResponse(ProtocolName.Canvas.GetTraceLog)]
	public class GetTraceLogCommandResponse
	{
		/// <summary>
		/// Gets or sets TraceLog
		/// </summary>
		public TraceLog TraceLog { get; set; }
	}
}
