using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Enables promise tracking, information about <code>Promise</code>s created or updated will now be stored on the backend.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.EnablePromiseTracker)]
	[SupportedBy("Chrome")]
	public class EnablePromiseTrackerCommandResponse
	{
	}
}
