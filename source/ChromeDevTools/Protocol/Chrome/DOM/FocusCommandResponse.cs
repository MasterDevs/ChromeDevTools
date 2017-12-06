using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Focus)]
	[SupportedBy("Chrome")]
	public class FocusCommandResponse
	{
	}
}
