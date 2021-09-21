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
		/// Gets or sets The index of the related DOM node in the `domNodes` array returned by `getSnapshot`.
		/// </summary>
		public long DomNodeIndex { get; set; }
		/// <summary>
		/// Gets or sets The bounding box in document coordinates. Note that scroll offset of the document is ignored.
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
		public InlineTextBox[] InlineTextNodes { get; set; }
		/// <summary>
		/// Gets or sets Index into the `computedStyles` array returned by `getSnapshot`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? StyleIndex { get; set; }
		/// <summary>
		/// Gets or sets Global paint order index, which is determined by the stacking order of the nodes. Nodes
		/// that are painted together will have the same index. Only provided if includePaintOrder in
		/// getSnapshot was true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? PaintOrder { get; set; }
		/// <summary>
		/// Gets or sets Set to true to indicate the element begins a new stacking context.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsStackingContext { get; set; }
	}
}
