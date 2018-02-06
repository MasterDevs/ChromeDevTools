using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Called when a pseudo element is removed from an element.
	/// </summary>
	[Event(ProtocolName.DOM.PseudoElementRemoved)]
	[SupportedBy("Chrome")]
	public class PseudoElementRemovedEvent
	{
		/// <summary>
		/// Gets or sets Pseudo element's parent element id.
		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or sets The removed pseudo element id.
		/// </summary>
		public long PseudoElementId { get; set; }
	}
}
