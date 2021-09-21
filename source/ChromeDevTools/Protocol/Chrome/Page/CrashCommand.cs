using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Crashes renderer on the IO thread, generates minidumps.
	/// </summary>
	[Command(ProtocolName.Page.Crash)]
	[SupportedBy("Chrome")]
	public class CrashCommand: ICommand<CrashCommandResponse>
	{
	}
}
