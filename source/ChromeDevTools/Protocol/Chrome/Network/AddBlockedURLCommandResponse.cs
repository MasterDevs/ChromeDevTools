using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Blocks specific URL from loading.
	/// </summary>
	[CommandResponse(ProtocolName.Network.AddBlockedURL)]
	[SupportedBy("Chrome")]
	public class AddBlockedURLCommandResponse
	{
	}
}
