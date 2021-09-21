using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Attaches to the browser target, only uses flat sessionId mode.
	/// </summary>
	[CommandResponse(ProtocolName.Target.AttachToBrowserTarget)]
	[SupportedBy("Chrome")]
	public class AttachToBrowserTargetCommandResponse
	{
		/// <summary>
		/// Gets or sets Id assigned to the session.
		/// </summary>
		public string SessionId { get; set; }
	}
}
