using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Controls whether to discover available targets and notify via <code>targetCreated/targetInfoChanged/targetDestroyed</code> events.
	/// </summary>
	[Command(ProtocolName.Target.SetDiscoverTargets)]
	[SupportedBy("Chrome")]
	public class SetDiscoverTargetsCommand: ICommand<SetDiscoverTargetsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to discover available targets.
		/// </summary>
		public bool Discover { get; set; }
	}
}
