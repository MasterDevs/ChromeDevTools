using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[CommandResponse(ProtocolName.Worker.ConnectToWorker)]
	[SupportedBy("iOS")]
	public class ConnectToWorkerCommandResponse
	{
	}
}
