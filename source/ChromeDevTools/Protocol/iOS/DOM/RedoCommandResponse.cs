using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Redo)]
	[SupportedBy("iOS")]
	public class RedoCommandResponse
	{
	}
}
