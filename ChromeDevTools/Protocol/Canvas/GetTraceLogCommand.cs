using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	[Command(ProtocolName.Canvas.GetTraceLog)]
	public class GetTraceLogCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets StartOffset
		/// </summary>
		public long StartOffset { get; set; }
		/// <summary>
		/// Gets or sets MaxLength
		/// </summary>
		public long MaxLength { get; set; }
	}
}
