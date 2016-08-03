using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Tells whether screencast is supported.
	/// </summary>
	[Command(ProtocolName.Page.CanScreencast)]
	[SupportedBy("Chrome")]
	public class CanScreencastCommand
	{
	}
}
