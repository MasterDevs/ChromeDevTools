using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Collect type profile.
	/// </summary>
	[Command(ProtocolName.Profiler.TakeTypeProfile)]
	[SupportedBy("Chrome")]
	public class TakeTypeProfileCommand: ICommand<TakeTypeProfileCommandResponse>
	{
	}
}
