using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[Command(ProtocolName.Runtime.IsRunRequired)]
	[SupportedBy("Chrome")]
	public class IsRunRequiredCommand
	{
	}
}
