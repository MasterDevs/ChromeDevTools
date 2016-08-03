using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Worker
{
	[Command(ProtocolName.Worker.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand
	{
	}
}
