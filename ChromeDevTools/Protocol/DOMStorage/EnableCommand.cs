using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMStorage
{
	/// <summary>
	/// Enables storage tracking, storage events will now be delivered to the client.
	/// </summary>
	[Command(ProtocolName.DOMStorage.Enable)]
	public class EnableCommand
	{
	}
}
