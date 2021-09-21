using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Attaches to the target with given id.
	/// </summary>
	[Command(ProtocolName.Target.AttachToTarget)]
	[SupportedBy("Chrome")]
	public class AttachToTargetCommand: ICommand<AttachToTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Gets or sets Enables "flat" access to the session via specifying sessionId attribute in the commands.
		/// We plan to make this the default, deprecate non-flattened mode,
		/// and eventually retire it. See crbug.com/991325.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Flatten { get; set; }
	}
}
