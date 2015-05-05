using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets node value for a node with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetNodeValue)]
	public class SetNodeValueCommandResponse
	{
	}
}
