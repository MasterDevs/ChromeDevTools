using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Tells inspected instance(worker or page) that it can run in case it was started paused.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Run)]
	[SupportedBy("iOS")]
	public class RunCommandResponse
	{
	}
}
