using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Returns version information.
	/// </summary>
	[Command(ProtocolName.Browser.GetVersion)]
	[SupportedBy("Chrome")]
	public class GetVersionCommand: ICommand<GetVersionCommandResponse>
	{
	}
}
