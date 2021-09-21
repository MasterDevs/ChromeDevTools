using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Retrieve native memory allocations profile
	/// collected since browser process startup.
	/// </summary>
	[Command(ProtocolName.Memory.GetBrowserSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetBrowserSamplingProfileCommand: ICommand<GetBrowserSamplingProfileCommandResponse>
	{
	}
}
