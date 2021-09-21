using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Stop collecting native memory profile.
	/// </summary>
	[Command(ProtocolName.Memory.StopSampling)]
	[SupportedBy("Chrome")]
	public class StopSamplingCommand: ICommand<StopSamplingCommandResponse>
	{
	}
}
