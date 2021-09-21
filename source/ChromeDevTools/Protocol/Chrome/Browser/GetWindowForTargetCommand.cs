using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get the browser window that contains the devtools target.
	/// </summary>
	[Command(ProtocolName.Browser.GetWindowForTarget)]
	[SupportedBy("Chrome")]
	public class GetWindowForTargetCommand: ICommand<GetWindowForTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets Devtools agent host id. If called as a part of the session, associated targetId is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
