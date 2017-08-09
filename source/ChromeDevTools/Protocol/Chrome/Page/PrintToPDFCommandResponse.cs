using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>
	[Command(ProtocolName.Page.SetOverlayMessage)]
	[SupportedBy("Chrome")]
	public class SetOverlayMessageCommand
	{
		/// <summary>
		/// Gets or sets Overlay message to display when paused in debugger.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
	}
}
