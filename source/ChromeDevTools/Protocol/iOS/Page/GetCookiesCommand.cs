using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the <code>cookies</code> field.
	/// </summary>
	[Command(ProtocolName.Page.GetCookies)]
	[SupportedBy("iOS")]
	public class GetCookiesCommand: ICommand<GetCookiesCommandResponse>
	{
	}
}
