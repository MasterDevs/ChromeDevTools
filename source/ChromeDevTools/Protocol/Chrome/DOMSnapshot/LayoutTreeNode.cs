using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Details of an element in the DOM tree with a LayoutObject.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LayoutTreeNode
	{
		/// <summary>
		/// Gets or sets The index of the related DOM node in the <code>domNodes</code> array returned by <code>getSnapshot</code>.
		/// </summary>
		public long DomNodeIndex { get; set; }
		/// <summary>
		/// Gets or sets The absolute position bounding box.
		/// </summary>
		public DOM.Rect BoundingBox { get; set; }
		/// <summary>
		/// Gets or sets Contents of the LayoutText, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string LayoutText { get; set; }
		/// <summary>
		/// Gets or sets The post-layout inline text nodes, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSS.InlineTextBox[] InlineTextNodes { get; set; }
		/// <summary>
		/// Gets or sets Index into the <code>computedStyles</code> array returned by <code>getSnapshot</code>.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? StyleIndex { get; set; }
	}
}
