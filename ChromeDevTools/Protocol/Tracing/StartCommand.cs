using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Start trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.Start)]
	public class StartCommand
	{
		/// <summary>
		/// Gets or sets Category/tag filter
		/// </summary>
		public string Categories { get; set; }
		/// <summary>
		/// Gets or sets Tracing options
		/// </summary>
		public string Options { get; set; }
		/// <summary>
		/// Gets or sets If set, the agent will issue bufferUsage events at this interval, specified in milliseconds
		/// </summary>
		public double BufferUsageReportingInterval { get; set; }
	}
}
