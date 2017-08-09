using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Cancels blocking of a specific URL from loading.
	/// </summary>
	[Command(ProtocolName.Network.RemoveBlockedURL)]
	[SupportedBy("Chrome")]
	public class RemoveBlockedURLCommand
	{
		/// <summary>
		/// Gets or sets URL to stop blocking.
		/// </summary>
		public string Url { get; set; }
	}
}
