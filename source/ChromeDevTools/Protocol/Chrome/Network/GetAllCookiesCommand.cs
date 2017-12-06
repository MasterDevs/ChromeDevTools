using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
	/// </summary>
	[Command(ProtocolName.Network.GetAllCookies)]
	[SupportedBy("Chrome")]
	public class GetAllCookiesCommand: ICommand<GetAllCookiesCommandResponse>
	{
	}
}
