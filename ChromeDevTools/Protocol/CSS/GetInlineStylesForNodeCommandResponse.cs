using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM attributes) for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetInlineStylesForNode)]
	public class GetInlineStylesForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Inline style for the specified DOM node.
		/// </summary>
		public CSSStyle InlineStyle { get; set; }
		/// <summary>
		/// Gets or sets Attribute-defined element style (e.g. resulting from "width=20 height=100%").
		/// </summary>
		public CSSStyle AttributesStyle { get; set; }
	}
}
