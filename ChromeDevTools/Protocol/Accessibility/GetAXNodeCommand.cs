using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// Fetches the accessibility node for this DOM node, if it exists.
	/// </summary>
	[Command(ProtocolName.Accessibility.GetAXNode)]
	public class GetAXNodeCommand
	{
		/// <summary>
		/// Gets or sets ID of node to get accessibility node for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
