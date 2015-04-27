using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.End)]
	public class EndCommand
	{
	}
}
