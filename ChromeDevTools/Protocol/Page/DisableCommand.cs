using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Disables page domain notifications.
	/// </summary>
	[Command(ProtocolName.Page.Disable)]
	public class DisableCommand
	{
	}
}
