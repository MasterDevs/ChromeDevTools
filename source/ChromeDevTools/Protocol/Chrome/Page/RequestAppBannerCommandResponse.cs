using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[CommandResponse(ProtocolName.Page.RequestAppBanner)]
	[SupportedBy("Chrome")]
	public class RequestAppBannerCommandResponse
	{
	}
}
