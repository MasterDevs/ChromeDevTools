using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Inspector
{
	/// <summary>
	/// Fired when remote debugging connection is about to be terminated. Contains detach reason.
	/// </summary>
	[Event(ProtocolName.Inspector.Detached)]
	[SupportedBy("Chrome")]
	public class DetachedEvent
	{
		/// <summary>
		/// Gets or sets The reason why connection has been terminated.
		/// </summary>
		public string Reason { get; set; }
	}
}
