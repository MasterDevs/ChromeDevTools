using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.MarkUndoableState)]
	[SupportedBy("Chrome")]
	public class MarkUndoableStateCommandResponse
	{
	}
}
