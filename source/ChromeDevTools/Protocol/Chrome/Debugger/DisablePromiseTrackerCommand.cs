using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Disables promise tracking.
	/// </summary>
	[Command(ProtocolName.Debugger.DisablePromiseTracker)]
	[SupportedBy("Chrome")]
	public class DisablePromiseTrackerCommand
	{
	}
}
