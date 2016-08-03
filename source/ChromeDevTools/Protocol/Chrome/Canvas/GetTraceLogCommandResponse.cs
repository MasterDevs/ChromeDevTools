using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	[CommandResponse(ProtocolName.Canvas.GetTraceLog)]
	[SupportedBy("Chrome")]
	public class GetTraceLogCommandResponse
	{
		/// <summary>
		/// Gets or sets TraceLog
		/// </summary>
		public TraceLog TraceLog { get; set; }
	}
}
