using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetComputedStyleForNode)]
	public class GetComputedStyleForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Computed style for the specified DOM node.
		/// </summary>
		public CSSComputedStyleProperty[] ComputedStyle { get; set; }
	}
}
