using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>
	[Command(ProtocolName.DOM.Undo)]
	[SupportedBy("iOS")]
	public class UndoCommand: ICommand<UndoCommandResponse>
	{
	}
}
