using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Set position and/or size of the browser window.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.SetWindowBounds)]
	[SupportedBy("Chrome")]
	public class SetWindowBoundsCommandResponse
	{
	}
}
