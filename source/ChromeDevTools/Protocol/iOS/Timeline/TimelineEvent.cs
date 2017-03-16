using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Timeline record contains information about the recorded activity.
	/// </summary>
	[SupportedBy("iOS")]
	public class TimelineEvent
	{
		/// <summary>
		/// Gets or sets Event type.
		/// </summary>
		public EventType Type { get; set; }
		/// <summary>
		/// Gets or sets Event data.
		/// </summary>
		public object Data { get; set; }
		/// <summary>
		/// Gets or sets Nested records.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TimelineEvent[] Children { get; set; }
	}
}
