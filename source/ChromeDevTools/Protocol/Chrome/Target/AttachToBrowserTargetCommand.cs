using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Attaches to the browser target, only uses flat sessionId mode.
	/// </summary>
	[Command(ProtocolName.Target.AttachToBrowserTarget)]
	[SupportedBy("Chrome")]
	public class AttachToBrowserTargetCommand: ICommand<AttachToBrowserTargetCommandResponse>
	{
	}
}
