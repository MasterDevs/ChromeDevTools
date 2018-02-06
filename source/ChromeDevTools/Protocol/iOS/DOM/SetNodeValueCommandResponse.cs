using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Sets node value for a node with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetNodeValue)]
	[SupportedBy("iOS")]
	public class SetNodeValueCommandResponse
	{
	}
}
