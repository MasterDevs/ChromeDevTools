using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Removes attribute with given name from an element with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.RemoveAttribute)]
	public class RemoveAttributeCommandResponse
	{
	}
}
