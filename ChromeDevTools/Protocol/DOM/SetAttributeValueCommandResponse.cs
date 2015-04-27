using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets attribute for an element with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetAttributeValue)]
	public class SetAttributeValueCommandResponse
	{
	}
}
