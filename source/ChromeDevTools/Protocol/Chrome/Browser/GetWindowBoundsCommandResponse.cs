using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get position and size of the browser window.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.GetWindowBounds)]
	[SupportedBy("Chrome")]
	public class GetWindowBoundsCommandResponse
	{
		/// <summary>
		/// Gets or sets Bounds information of the window. When window state is 'minimized', the restored window position and size are returned.
		/// </summary>
		public Bounds Bounds { get; set; }
	}
}
