using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Discards collected exceptions and console API calls.
	/// </summary>
	[Command(ProtocolName.Runtime.DiscardConsoleEntries)]
	[SupportedBy("Chrome")]
	public class DiscardConsoleEntriesCommand: ICommand<DiscardConsoleEntriesCommandResponse>
	{
	}
}
