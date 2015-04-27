using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMStorage
{
	/// <summary>
	/// Enables storage tracking, storage events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.DOMStorage.Enable)]
	public class EnableCommandResponse
	{
	}
}
