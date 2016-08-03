using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// A sample collected by evaluating a probe breakpoint action.
	/// </summary>
	[SupportedBy("iOS")]
	public class ProbeSample
	{
		/// <summary>
		/// Gets or sets Identifier of the probe breakpoint action that created the sample.
		/// </summary>
		public long ProbeId { get; set; }
		/// <summary>
		/// Gets or sets Unique identifier for this sample.
		/// </summary>
		public long SampleId { get; set; }
		/// <summary>
		/// Gets or sets A batch identifier which is the same for all samples taken at the same breakpoint hit.
		/// </summary>
		public long BatchId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp of when the sample was taken.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Contents of the sample.
		/// </summary>
		public Runtime.RemoteObject Payload { get; set; }
	}
}
