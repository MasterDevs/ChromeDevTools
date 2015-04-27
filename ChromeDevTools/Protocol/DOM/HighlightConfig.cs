using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Configuration data for the highlighting of page elements.
	/// </summary>
	public class HighlightConfig
	{
		/// <summary>
		/// Gets or sets Whether the node info tooltip should be shown (default: false).
		/// </summary>
		public bool ShowInfo { get; set; }
		/// <summary>
		/// Gets or sets Whether the rulers should be shown (default: false).
		/// </summary>
		public bool ShowRulers { get; set; }
		/// <summary>
		/// Gets or sets Whether the extension lines from node to the rulers should be shown (default: false).
		/// </summary>
		public bool ShowExtensionLines { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight fill color (default: transparent).
		/// </summary>
		public RGBA ContentColor { get; set; }
		/// <summary>
		/// Gets or sets The padding highlight fill color (default: transparent).
		/// </summary>
		public RGBA PaddingColor { get; set; }
		/// <summary>
		/// Gets or sets The border highlight fill color (default: transparent).
		/// </summary>
		public RGBA BorderColor { get; set; }
		/// <summary>
		/// Gets or sets The margin highlight fill color (default: transparent).
		/// </summary>
		public RGBA MarginColor { get; set; }
		/// <summary>
		/// Gets or sets The event target element highlight fill color (default: transparent).
		/// </summary>
		public RGBA EventTargetColor { get; set; }
		/// <summary>
		/// Gets or sets The shape outside fill color (default: transparent).
		/// </summary>
		public RGBA ShapeColor { get; set; }
		/// <summary>
		/// Gets or sets The shape margin fill color (default: transparent).
		/// </summary>
		public RGBA ShapeMarginColor { get; set; }
	}
}
