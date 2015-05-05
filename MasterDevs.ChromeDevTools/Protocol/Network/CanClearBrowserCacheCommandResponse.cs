using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>
	[CommandResponse(ProtocolName.Network.CanClearBrowserCache)]
	public class CanClearBrowserCacheCommandResponse
	{
		/// <summary>
		/// Gets or sets True if browser cache can be cleared.
		/// </summary>
		public bool Result { get; set; }
	}
}
