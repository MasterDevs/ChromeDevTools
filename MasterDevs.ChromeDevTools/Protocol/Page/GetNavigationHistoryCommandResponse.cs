using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns navigation history for the current page.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetNavigationHistory)]
	public class GetNavigationHistoryCommandResponse
	{
		/// <summary>
		/// Gets or sets Index of the current navigation history entry.
		/// </summary>
		public long CurrentIndex { get; set; }
		/// <summary>
		/// Gets or sets Array of navigation history entries.
		/// </summary>
		public NavigationEntry[] Entries { get; set; }
	}
}
