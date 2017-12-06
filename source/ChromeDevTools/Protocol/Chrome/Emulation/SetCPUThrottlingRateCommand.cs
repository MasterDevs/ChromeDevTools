using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Enables CPU throttling to emulate slow CPUs.
	/// </summary>
	[Command(ProtocolName.Emulation.SetCPUThrottlingRate)]
	[SupportedBy("Chrome")]
	public class SetCPUThrottlingRateCommand: ICommand<SetCPUThrottlingRateCommandResponse>
	{
		/// <summary>
		/// Gets or sets Throttling rate as a slowdown factor (1 is no throttle, 2 is 2x slowdown, etc).
		/// </summary>
		public double Rate { get; set; }
	}
}
