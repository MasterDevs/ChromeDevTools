using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Configures overlay.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ConfigureOverlay)]
	[SupportedBy("Chrome")]
	public class ConfigureOverlayCommandResponse
	{
	}
}
