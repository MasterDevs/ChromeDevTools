using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Sends protocol message over session with given id.
	/// </summary>
	[Command(ProtocolName.Target.SendMessageToTarget)]
	[SupportedBy("Chrome")]
	public class SendMessageToTargetCommand: ICommand<SendMessageToTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets Message
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the session.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SessionId { get; set; }
		/// <summary>
		/// Gets or sets Deprecated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
