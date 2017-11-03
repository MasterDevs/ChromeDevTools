using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Notification sent after the virtual time has paused.
	/// </summary>
	[Event(ProtocolName.Emulation.VirtualTimePaused)]
	[SupportedBy("Chrome")]
	public class VirtualTimePausedEvent
	{
		/// <summary>
		/// Gets or sets The amount of virtual time that has elapsed in milliseconds since virtual time was first enabled.
		/// </summary>
		public long VirtualTimeElapsed { get; set; }
	}
}
