using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Blocks specific URL from loading.
	/// </summary>
	[Command(ProtocolName.Network.AddBlockedURL)]
	[SupportedBy("Chrome")]
	public class AddBlockedURLCommand
	{
		/// <summary>
		/// Gets or sets URL to block.
		/// </summary>
		public string Url { get; set; }
	}
}
