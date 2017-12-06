using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted. Backend then generates 'inspect' command upon element selection.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetInspectModeEnabled)]
	[SupportedBy("iOS")]
	public class SetInspectModeEnabledCommandResponse
	{
	}
}
