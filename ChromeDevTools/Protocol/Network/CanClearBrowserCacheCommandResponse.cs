using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
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
