using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.UpdateRegistration)]
	[SupportedBy("Chrome")]
	public class UpdateRegistrationCommandResponse
	{
	}
}
