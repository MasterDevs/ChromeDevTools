using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StopAllWorkers)]
	[SupportedBy("Chrome")]
	public class StopAllWorkersCommand: ICommand<StopAllWorkersCommandResponse>
	{
	}
}
