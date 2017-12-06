using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Undo)]
	[SupportedBy("iOS")]
	public class UndoCommandResponse
	{
	}
}
