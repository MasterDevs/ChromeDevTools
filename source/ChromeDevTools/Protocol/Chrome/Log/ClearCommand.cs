using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Clears the log.
	/// </summary>
	[Command(ProtocolName.Log.Clear)]
	[SupportedBy("Chrome")]
	public class ClearCommand
	{
	}
}
