using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Reports coverage delta since the last poll (either from an event like this, or from
	/// `takePreciseCoverage` for the current isolate. May only be sent if precise code
	/// coverage has been started. This event can be trigged by the embedder to, for example,
	/// trigger collection of coverage data immediatelly at a certain point in time.
	/// </summary>
	[Event(ProtocolName.Profiler.PreciseCoverageDeltaUpdate)]
	[SupportedBy("Chrome")]
	public class PreciseCoverageDeltaUpdateEvent
	{
		/// <summary>
		/// Gets or sets Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Identifier for distinguishing coverage events.
		/// </summary>
		public string Occassion { get; set; }
		/// <summary>
		/// Gets or sets Coverage data for the current isolate.
		/// </summary>
		public ScriptCoverage[] Result { get; set; }
	}
}
