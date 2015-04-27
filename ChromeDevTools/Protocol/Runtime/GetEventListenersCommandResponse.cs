using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns event listeners of the given object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetEventListeners)]
	public class GetEventListenersCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of relevant listeners.
		/// </summary>
		public EventListener[] Listeners { get; set; }
	}
}
