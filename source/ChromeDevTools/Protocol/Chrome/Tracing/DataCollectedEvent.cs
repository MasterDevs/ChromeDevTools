using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Contains an bucket of collected trace events. When tracing is stopped collected events will be send as a sequence of dataCollected events followed by tracingComplete event.
	/// </summary>
	[Event(ProtocolName.Tracing.DataCollected)]
	[SupportedBy("Chrome")]
	public class DataCollectedEvent
	{
		public class ValueArray
		{
		}

		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public ValueArray[] Value { get; set; }
	}
}
