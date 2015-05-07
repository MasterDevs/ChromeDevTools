using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Enables promise tracking, information about <code>Promise</code>s created or updated will now be stored on the backend.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.EnablePromiseTracker)]
	public class EnablePromiseTrackerCommandResponse
	{
	}
}
