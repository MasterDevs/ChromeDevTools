using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Start trace events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.Start)]
	public class StartCommandResponse
	{
	}
}
