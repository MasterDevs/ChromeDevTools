using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Worker
{
	[CommandResponse(ProtocolName.Worker.SetAutoconnectToWorkers)]
	[SupportedBy("Chrome")]
	public class SetAutoconnectToWorkersCommandResponse
	{
	}
}
