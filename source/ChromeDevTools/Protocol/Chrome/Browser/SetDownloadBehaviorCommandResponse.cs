using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Set the behavior when downloading a file.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.SetDownloadBehavior)]
	[SupportedBy("Chrome")]
	public class SetDownloadBehaviorCommandResponse
	{
	}
}
