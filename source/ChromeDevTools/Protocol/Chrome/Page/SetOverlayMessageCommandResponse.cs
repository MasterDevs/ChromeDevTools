using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetOverlayMessage)]
	[SupportedBy("Chrome")]
	public class SetOverlayMessageCommandResponse
	{
	}
}
