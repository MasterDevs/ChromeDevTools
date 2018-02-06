using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Start trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.Start)]
	[SupportedBy("Chrome")]
	public class StartCommand: ICommand<StartCommandResponse>
	{
		/// <summary>
		/// Gets or sets Category/tag filter
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Categories { get; set; }
		/// <summary>
		/// Gets or sets Tracing options
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Options { get; set; }
		/// <summary>
		/// Gets or sets If set, the agent will issue bufferUsage events at this interval, specified in milliseconds
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double BufferUsageReportingInterval { get; set; }
		/// <summary>
		/// Gets or sets Whether to report trace events as series of dataCollected events or to save trace to a stream (defaults to <code>ReportEvents</code>).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TransferMode { get; set; }
		/// <summary>
		/// Gets or sets 
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TraceConfig TraceConfig { get; set; }
	}
}
