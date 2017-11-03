using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Removes attribute with given name from an element with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.RemoveAttribute)]
	[SupportedBy("Chrome")]
	public class RemoveAttributeCommandResponse
	{
	}
}
