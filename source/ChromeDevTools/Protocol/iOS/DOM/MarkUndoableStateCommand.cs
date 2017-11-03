using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>
	[Command(ProtocolName.DOM.MarkUndoableState)]
	[SupportedBy("iOS")]
	public class MarkUndoableStateCommand: ICommand<MarkUndoableStateCommandResponse>
	{
	}
}
