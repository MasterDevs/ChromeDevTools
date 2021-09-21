using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Crashes browser on the main thread.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.Crash)]
	[SupportedBy("Chrome")]
	public class CrashCommandResponse
	{
	}
}
