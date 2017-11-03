using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Fired when <code>Element</code>'s inline style is modified via a CSS property modification.
	/// </summary>
	[Event(ProtocolName.DOM.InlineStyleInvalidated)]
	[SupportedBy("Chrome")]
	public class InlineStyleInvalidatedEvent
	{
		/// <summary>
		/// Gets or sets Ids of the nodes for which the inline styles have been invalidated.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
