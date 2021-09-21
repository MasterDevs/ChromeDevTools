using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets
	/// the current virtual time policy.  Note this supersedes any previous time budget.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetVirtualTimePolicy)]
	[SupportedBy("Chrome")]
	public class SetVirtualTimePolicyCommandResponse
	{
		/// <summary>
		/// Gets or sets Absolute timestamp at which virtual time was first enabled (up time in milliseconds).
		/// </summary>
		public double VirtualTimeTicksBase { get; set; }
	}
}
