using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.MarkUndoableState)]
	public class MarkUndoableStateCommandResponse
	{
	}
}
