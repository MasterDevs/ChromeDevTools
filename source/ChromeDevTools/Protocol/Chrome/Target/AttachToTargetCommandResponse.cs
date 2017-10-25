using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Attaches to the target with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Target.AttachToTarget)]
	[SupportedBy("Chrome")]
	public class AttachToTargetCommandResponse
	{
		/// <summary>
		/// Gets or sets Whether attach succeeded.
		/// </summary>
		public bool Success { get; set; }
	}
}
