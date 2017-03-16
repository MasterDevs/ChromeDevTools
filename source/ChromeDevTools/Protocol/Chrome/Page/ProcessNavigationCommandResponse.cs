using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Should be sent in response to a navigationRequested or a redirectRequested event, telling the browser how to handle the navigation.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ProcessNavigation)]
	[SupportedBy("Chrome")]
	public class ProcessNavigationCommandResponse
	{
	}
}
