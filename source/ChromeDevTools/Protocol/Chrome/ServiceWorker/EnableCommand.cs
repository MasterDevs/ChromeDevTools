using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
