using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Close browser gracefully.
	/// </summary>
	[Command(ProtocolName.Browser.Close)]
	[SupportedBy("Chrome")]
	public class CloseCommand: ICommand<CloseCommandResponse>
	{
	}
}
