using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Enables page domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Enable)]
	public class EnableCommandResponse
	{
	}
}
