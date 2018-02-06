using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Stops capturing instrumentation events.
	/// </summary>
	[Command(ProtocolName.Timeline.Stop)]
	[SupportedBy("iOS")]
	public class StopCommand: ICommand<StopCommandResponse>
	{
	}
}
