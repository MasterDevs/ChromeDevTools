using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[CommandResponse(ProtocolName.Emulation.SetDocumentCookieDisabled)]
	[SupportedBy("Chrome")]
	public class SetDocumentCookieDisabledCommandResponse
	{
	}
}
