using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Fired when recording has stopped.
	/// </summary>
	[Event(ProtocolName.Timeline.RecordingStopped)]
	[SupportedBy("iOS")]
	public class RecordingStoppedEvent
	{
		/// <summary>
		/// Gets or sets End time of this recording.
		/// </summary>
		public double EndTime { get; set; }
	}
}
