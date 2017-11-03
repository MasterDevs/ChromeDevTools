using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Set the behavior when downloading a file.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetDownloadBehavior)]
	[SupportedBy("Chrome")]
	public class SetDownloadBehaviorCommandResponse
	{
	}
}
