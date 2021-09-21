using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Inject object to the target's main frame that provides a communication
	/// channel with browser target.

	/// Injected object will be available as `window[bindingName]`.

	/// The object has the follwing API:
	/// - `binding.send(json)` - a method to send messages over the remote debugging protocol
	/// - `binding.onmessage = json => handleMessage(json)` - a callback that will be called for the protocol notifications and command responses.
	/// </summary>
	[CommandResponse(ProtocolName.Target.ExposeDevToolsProtocol)]
	[SupportedBy("Chrome")]
	public class ExposeDevToolsProtocolCommandResponse
	{
	}
}
