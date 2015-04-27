using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Tells whether screencast is supported.
	/// </summary>
	[Command(ProtocolName.Page.CanScreencast)]
	public class CanScreencastCommand
	{
	}
}
