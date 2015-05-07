using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Disables promise tracking.
	/// </summary>
	[Command(ProtocolName.Debugger.DisablePromiseTracker)]
	public class DisablePromiseTrackerCommand
	{
	}
}
