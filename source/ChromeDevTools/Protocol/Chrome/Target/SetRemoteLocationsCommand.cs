using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Enables target discovery for the specified locations, when <code>setDiscoverTargets</code> was set to <code>true</code>.
	/// </summary>
	[Command(ProtocolName.Target.SetRemoteLocations)]
	[SupportedBy("Chrome")]
	public class SetRemoteLocationsCommand: ICommand<SetRemoteLocationsCommandResponse>
	{
		/// <summary>
		/// Gets or sets List of remote locations.
		/// </summary>
		public RemoteLocation[] Locations { get; set; }
	}
}
