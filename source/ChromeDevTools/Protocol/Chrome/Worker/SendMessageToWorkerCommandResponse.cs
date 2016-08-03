using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Worker
{
	[CommandResponse(ProtocolName.Worker.SendMessageToWorker)]
	[SupportedBy("Chrome")]
	public class SendMessageToWorkerCommandResponse
	{
	}
}
