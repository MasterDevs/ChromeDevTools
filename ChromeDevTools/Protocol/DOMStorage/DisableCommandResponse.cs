using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMStorage
{
	/// <summary>
	/// Disables storage tracking, prevents storage events from being sent to the client.
	/// </summary>
	[CommandResponse(ProtocolName.DOMStorage.Disable)]
	public class DisableCommandResponse
	{
	}
}
