using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Fired when recording has started.
	/// </summary>
	[Event(ProtocolName.Timeline.RecordingStarted)]
	[SupportedBy("iOS")]
	public class RecordingStartedEvent
	{
		/// <summary>
		/// Gets or sets Start time of this new recording.
		/// </summary>
		public double StartTime { get; set; }
	}
}
