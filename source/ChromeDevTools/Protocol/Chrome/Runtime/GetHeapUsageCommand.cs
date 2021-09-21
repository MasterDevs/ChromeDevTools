using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns the JavaScript heap usage.
	/// It is the total usage of the corresponding isolate not scoped to a particular Runtime.
	/// </summary>
	[Command(ProtocolName.Runtime.GetHeapUsage)]
	[SupportedBy("Chrome")]
	public class GetHeapUsageCommand: ICommand<GetHeapUsageCommandResponse>
	{
	}
}
