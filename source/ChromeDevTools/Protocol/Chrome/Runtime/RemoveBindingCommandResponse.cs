using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// This method does not remove binding function from global object but
	/// unsubscribes current runtime agent from Runtime.bindingCalled notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.RemoveBinding)]
	[SupportedBy("Chrome")]
	public class RemoveBindingCommandResponse
	{
	}
}
