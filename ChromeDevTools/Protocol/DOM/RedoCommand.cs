using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>
	[Command(ProtocolName.DOM.Redo)]
	public class RedoCommand
	{
	}
}
