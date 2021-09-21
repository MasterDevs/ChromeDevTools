using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fetches the resource and returns the content.
	/// </summary>
	[CommandResponse(ProtocolName.Network.LoadNetworkResource)]
	[SupportedBy("Chrome")]
	public class LoadNetworkResourceCommandResponse
	{
		/// <summary>
		/// Gets or sets Resource
		/// </summary>
		public LoadNetworkResourcePageResult Resource { get; set; }
	}
}
