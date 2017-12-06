using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Sets the timing of an animation node.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.SetTiming)]
	[SupportedBy("Chrome")]
	public class SetTimingCommandResponse
	{
	}
}
