using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Toggles navigation throttling which allows programatic control over navigation and redirect response.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetControlNavigations)]
	[SupportedBy("Chrome")]
	public class SetControlNavigationsCommandResponse
	{
	}
}
