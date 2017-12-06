using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Simulate a memory pressure notification in all processes.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.SimulatePressureNotification)]
	[SupportedBy("Chrome")]
	public class SimulatePressureNotificationCommandResponse
	{
	}
}
