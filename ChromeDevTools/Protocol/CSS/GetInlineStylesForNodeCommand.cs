using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM attributes) for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetInlineStylesForNode)]
	public class GetInlineStylesForNodeCommand
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
