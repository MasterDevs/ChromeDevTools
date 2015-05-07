using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Disables promise tracking.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.DisablePromiseTracker)]
	public class DisablePromiseTrackerCommandResponse
	{
	}
}
