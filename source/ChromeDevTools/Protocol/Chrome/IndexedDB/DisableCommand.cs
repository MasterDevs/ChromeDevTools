using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>
	[Command(ProtocolName.IndexedDB.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
