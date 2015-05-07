using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Removes node with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.RemoveNode)]
	public class RemoveNodeCommandResponse
	{
	}
}
