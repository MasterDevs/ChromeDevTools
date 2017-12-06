using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Fires when a new probe sample is collected.
	/// </summary>
	[Event(ProtocolName.Debugger.DidSampleProbe)]
	[SupportedBy("iOS")]
	public class DidSampleProbeEvent
	{
		/// <summary>
		/// Gets or sets A collected probe sample.
		/// </summary>
		public ProbeSample Sample { get; set; }
	}
}
