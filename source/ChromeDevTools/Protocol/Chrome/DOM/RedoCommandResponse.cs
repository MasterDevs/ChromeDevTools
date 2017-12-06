using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Redo)]
	[SupportedBy("Chrome")]
	public class RedoCommandResponse
	{
	}
}
