using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.SetDebugOnStart)]
	[SupportedBy("Chrome")]
	public class SetDebugOnStartCommandResponse
	{
	}
}
