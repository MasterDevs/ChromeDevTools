using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>
	[Command(ProtocolName.Debugger.SetOverlayMessage)]
	[SupportedBy("iOS")]
	public class SetOverlayMessageCommand: ICommand<SetOverlayMessageCommandResponse>
	{
		/// <summary>
		/// Gets or sets Overlay message to display when paused in debugger.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
	}
}
