using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Removes attribute with given name from an element with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.RemoveAttribute)]
	[SupportedBy("iOS")]
	public class RemoveAttributeCommandResponse
	{
	}
}
