using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Timeline
{
	/// <summary>
	/// Timeline record contains information about the recorded activity.
	/// </summary>
	[SupportedBy("Chrome")]
	public class TimelineEvent
	{
		/// <summary>
		/// Gets or sets Event type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Event data.
		/// </summary>
		public object Data { get; set; }
		/// <summary>
		/// Gets or sets Start time.
		/// </summary>
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets End time.
		/// </summary>
		public double EndTime { get; set; }
		/// <summary>
		/// Gets or sets Nested records.
		/// </summary>
		public TimelineEvent[] Children { get; set; }
		/// <summary>
		/// Gets or sets If present, identifies the thread that produced the event.
		/// </summary>
		public string Thread { get; set; }
		/// <summary>
		/// Gets or sets Stack trace.
		/// </summary>
		public Console.CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Unique identifier of the frame within the page that the event relates to.
		/// </summary>
		public string FrameId { get; set; }
	}
}
