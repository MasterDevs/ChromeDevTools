using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>
	[Command(ProtocolName.DOM.Focus)]
	public class FocusCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to focus.
		/// </summary>
		public long NodeId { get; set; }
	}
}
