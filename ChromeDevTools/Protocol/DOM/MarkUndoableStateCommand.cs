using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>
	[Command(ProtocolName.DOM.MarkUndoableState)]
	public class MarkUndoableStateCommand
	{
	}
}
