using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Details of an element in the DOM tree with a LayoutObject.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LayoutTreeNode
	{
		/// <summary>
		/// Gets or sets The id of the related DOM node matching one from DOM.GetDocument.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets The absolute position bounding box.
		/// </summary>
		public DOM.Rect BoundingBox { get; set; }
		/// <summary>
		/// Gets or sets Contents of the LayoutText if any
		/// </summary>
		public string LayoutText { get; set; }
		/// <summary>
		/// Gets or sets The post layout inline text nodes, if any.
		/// </summary>
		public InlineTextBox[] InlineTextNodes { get; set; }
		/// <summary>
		/// Gets or sets Index into the computedStyles array returned by getLayoutTreeAndStyles.
		/// </summary>
		public long StyleIndex { get; set; }
	}
}
