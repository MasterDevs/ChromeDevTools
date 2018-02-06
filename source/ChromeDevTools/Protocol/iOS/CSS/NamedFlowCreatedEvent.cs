using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Fires when a Named Flow is created.
	/// </summary>
	[Event(ProtocolName.CSS.NamedFlowCreated)]
	[SupportedBy("iOS")]
	public class NamedFlowCreatedEvent
	{
		/// <summary>
		/// Gets or sets The new Named Flow.
		/// </summary>
		public NamedFlow NamedFlow { get; set; }
	}
}
