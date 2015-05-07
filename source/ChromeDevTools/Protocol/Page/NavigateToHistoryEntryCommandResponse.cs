using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Navigates current page to the given history entry.
	/// </summary>
	[CommandResponse(ProtocolName.Page.NavigateToHistoryEntry)]
	public class NavigateToHistoryEntryCommandResponse
	{
	}
}
