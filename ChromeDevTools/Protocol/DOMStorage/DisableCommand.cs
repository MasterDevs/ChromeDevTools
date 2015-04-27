using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMStorage
{
	/// <summary>
	/// Disables storage tracking, prevents storage events from being sent to the client.
	/// </summary>
	[Command(ProtocolName.DOMStorage.Disable)]
	public class DisableCommand
	{
	}
}
