using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Start trace events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.Start)]
	public class StartCommandResponse
	{
	}
}
