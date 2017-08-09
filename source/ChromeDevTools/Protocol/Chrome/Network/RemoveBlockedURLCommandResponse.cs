using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Cancels blocking of a specific URL from loading.
	/// </summary>
	[CommandResponse(ProtocolName.Network.RemoveBlockedURL)]
	[SupportedBy("Chrome")]
	public class RemoveBlockedURLCommandResponse
	{
	}
}
