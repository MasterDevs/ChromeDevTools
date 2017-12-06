using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StartSampling)]
	[SupportedBy("Chrome")]
	public class StartSamplingCommand: ICommand<StartSamplingCommandResponse>
	{
		/// <summary>
		/// Gets or sets Average sample interval in bytes. Poisson distribution is used for the intervals. The default value is 32768 bytes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double SamplingInterval { get; set; }
	}
}
