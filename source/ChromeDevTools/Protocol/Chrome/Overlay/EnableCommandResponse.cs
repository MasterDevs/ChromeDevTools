using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Enables domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
