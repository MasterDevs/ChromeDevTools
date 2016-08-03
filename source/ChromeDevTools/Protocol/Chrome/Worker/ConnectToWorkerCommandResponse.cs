using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Worker
{
	[CommandResponse(ProtocolName.Worker.ConnectToWorker)]
	[SupportedBy("Chrome")]
	public class ConnectToWorkerCommandResponse
	{
	}
}
