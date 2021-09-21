using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Enable type profile.
	/// </summary>
	[Command(ProtocolName.Profiler.StartTypeProfile)]
	[SupportedBy("Chrome")]
	public class StartTypeProfileCommand: ICommand<StartTypeProfileCommandResponse>
	{
	}
}
