using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Tells inspected instance(worker or page) that it can run in case it was started paused.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Run)]
	[SupportedBy("Chrome")]
	public class RunCommandResponse
	{
	}
}
