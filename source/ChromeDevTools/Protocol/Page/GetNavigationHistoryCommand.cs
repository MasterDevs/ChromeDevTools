using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns navigation history for the current page.
	/// </summary>
	[Command(ProtocolName.Page.GetNavigationHistory)]
	public class GetNavigationHistoryCommand
	{
	}
}
