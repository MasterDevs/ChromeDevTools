using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get the browser window that contains the devtools target.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.GetWindowForTarget)]
	[SupportedBy("Chrome")]
	public class GetWindowForTargetCommandResponse
	{
		/// <summary>
		/// Gets or sets Browser window id.
		/// </summary>
		public long WindowId { get; set; }
		/// <summary>
		/// Gets or sets Bounds information of the window. When window state is 'minimized', the restored window position and size are returned.
		/// </summary>
		public Bounds Bounds { get; set; }
	}
}
