using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets attribute for an element with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetAttributeValue)]
	public class SetAttributeValueCommandResponse
	{
	}
}
