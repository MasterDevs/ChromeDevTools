using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// This is fired whenever the list of available sinks changes. A sink is a
	/// device or a software surface that you can cast to.
	/// </summary>
	[Event(ProtocolName.Cast.SinksUpdated)]
	[SupportedBy("Chrome")]
	public class SinksUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Sinks
		/// </summary>
		public Sink[] Sinks { get; set; }
	}
}
