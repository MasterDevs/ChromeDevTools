using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets the current virtual time policy.  Note this supersedes any previous time budget.
	/// </summary>
	[Command(ProtocolName.Emulation.SetVirtualTimePolicy)]
	[SupportedBy("Chrome")]
	public class SetVirtualTimePolicyCommand: ICommand<SetVirtualTimePolicyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Policy
		/// </summary>
		public string Policy { get; set; }
		/// <summary>
		/// Gets or sets If set, after this many virtual milliseconds have elapsed virtual time will be paused and a virtualTimeBudgetExpired event is sent.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Budget { get; set; }
	}
}
