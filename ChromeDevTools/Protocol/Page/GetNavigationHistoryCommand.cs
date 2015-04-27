using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns navigation history for the current page.
	/// </summary>
	[Command(ProtocolName.Page.GetNavigationHistory)]
	public class GetNavigationHistoryCommand
	{
	}
}
