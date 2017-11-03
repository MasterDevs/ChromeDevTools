using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns event listeners relevant to the node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetEventListenersForNode)]
	[SupportedBy("iOS")]
	public class GetEventListenersForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of relevant listeners.
		/// </summary>
		public EventListener[] Listeners { get; set; }
	}
}
