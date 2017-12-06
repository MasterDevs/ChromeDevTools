using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetOverlayMessage)]
	[SupportedBy("iOS")]
	public class SetOverlayMessageCommandResponse
	{
	}
}
