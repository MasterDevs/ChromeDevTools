using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Disable type profile. Disabling releases type profile data collected so far.
	/// </summary>
	[Command(ProtocolName.Profiler.StopTypeProfile)]
	[SupportedBy("Chrome")]
	public class StopTypeProfileCommand: ICommand<StopTypeProfileCommandResponse>
	{
	}
}
