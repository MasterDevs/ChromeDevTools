using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetComputedStyleForNode)]
	public class GetComputedStyleForNodeCommand
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
