using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Cancel a download if in progress
	/// </summary>
	[CommandResponse(ProtocolName.Browser.CancelDownload)]
	[SupportedBy("Chrome")]
	public class CancelDownloadCommandResponse
	{
	}
}
