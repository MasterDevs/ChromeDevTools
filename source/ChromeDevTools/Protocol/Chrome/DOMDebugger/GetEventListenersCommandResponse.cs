using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Returns event listeners of the given object.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.GetEventListeners)]
	[SupportedBy("Chrome")]
	public class GetEventListenersCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of relevant listeners.
		/// </summary>
		public EventListener[] Listeners { get; set; }
	}
}
