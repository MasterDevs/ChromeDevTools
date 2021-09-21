using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Tries to update the web lifecycle state of the page.
	/// It will transition the page to the given state according to:
	/// https://github.com/WICG/web-lifecycle/
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetWebLifecycleState)]
	[SupportedBy("Chrome")]
	public class SetWebLifecycleStateCommandResponse
	{
	}
}
