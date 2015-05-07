using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Tells whether screencast is supported.
	/// </summary>
	[Command(ProtocolName.Page.CanScreencast)]
	public class CanScreencastCommand
	{
	}
}
