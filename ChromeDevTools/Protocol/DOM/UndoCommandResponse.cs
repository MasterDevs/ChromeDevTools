using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Undo)]
	public class UndoCommandResponse
	{
	}
}
