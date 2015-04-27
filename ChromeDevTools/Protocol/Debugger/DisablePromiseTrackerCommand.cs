using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Disables promise tracking.
	/// </summary>
	[Command(ProtocolName.Debugger.DisablePromiseTracker)]
	public class DisablePromiseTrackerCommand
	{
	}
}
