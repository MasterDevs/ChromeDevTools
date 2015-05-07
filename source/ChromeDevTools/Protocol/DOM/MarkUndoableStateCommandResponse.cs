using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.MarkUndoableState)]
	public class MarkUndoableStateCommandResponse
	{
	}
}
