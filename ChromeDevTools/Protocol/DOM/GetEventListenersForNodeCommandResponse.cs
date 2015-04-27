using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns event listeners relevant to the node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetEventListenersForNode)]
	public class GetEventListenersForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of relevant listeners.
		/// </summary>
		public EventListener[] Listeners { get; set; }
	}
}
