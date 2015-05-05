using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Navigate)]
	public class NavigateCommandResponse
	{
		/// <summary>
		/// Gets or sets Frame id that will be navigated.
		/// </summary>
		public string FrameId { get; set; }
	}
}
