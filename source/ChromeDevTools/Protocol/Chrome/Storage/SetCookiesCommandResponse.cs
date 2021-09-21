using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Sets given cookies.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.SetCookies)]
	[SupportedBy("Chrome")]
	public class SetCookiesCommandResponse
	{
	}
}
