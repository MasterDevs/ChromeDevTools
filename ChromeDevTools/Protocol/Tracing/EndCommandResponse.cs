using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.End)]
	public class EndCommandResponse
	{
	}
}
