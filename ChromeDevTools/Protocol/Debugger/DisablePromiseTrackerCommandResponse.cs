using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Disables promise tracking.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.DisablePromiseTracker)]
	public class DisablePromiseTrackerCommandResponse
	{
	}
}
