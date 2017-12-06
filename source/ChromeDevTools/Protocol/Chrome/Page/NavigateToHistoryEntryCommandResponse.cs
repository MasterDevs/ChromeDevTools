using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Navigates current page to the given history entry.
	/// </summary>
	[CommandResponse(ProtocolName.Page.NavigateToHistoryEntry)]
	[SupportedBy("Chrome")]
	public class NavigateToHistoryEntryCommandResponse
	{
	}
}
