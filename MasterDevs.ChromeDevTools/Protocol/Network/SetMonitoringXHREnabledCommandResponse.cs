using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Toggles monitoring of XMLHttpRequest. If <code>true</code>, console will receive messages upon each XHR issued.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetMonitoringXHREnabled)]
	public class SetMonitoringXHREnabledCommandResponse
	{
	}
}
