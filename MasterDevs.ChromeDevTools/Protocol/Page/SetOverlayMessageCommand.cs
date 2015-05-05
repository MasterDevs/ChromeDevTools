using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>
	[Command(ProtocolName.Page.SetOverlayMessage)]
	public class SetOverlayMessageCommand
	{
		/// <summary>
		/// Gets or sets Overlay message to display when paused in debugger.
		/// </summary>
		public string Message { get; set; }
	}
}
