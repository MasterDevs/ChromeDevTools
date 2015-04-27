using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Information about a compositing layer.
	/// </summary>
	public class Layer
	{
		/// <summary>
		/// Gets or sets The unique id for this layer.
		/// </summary>
		public string LayerId { get; set; }
		/// <summary>
		/// Gets or sets The id of parent (not present for root).
		/// </summary>
		public string ParentLayerId { get; set; }
		/// <summary>
		/// Gets or sets The backend id for the node associated with this layer.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets Offset from parent layer, X coordinate.
		/// </summary>
		public double OffsetX { get; set; }
		/// <summary>
		/// Gets or sets Offset from parent layer, Y coordinate.
		/// </summary>
		public double OffsetY { get; set; }
		/// <summary>
		/// Gets or sets Layer width.
		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Gets or sets Layer height.
		/// </summary>
		public double Height { get; set; }
		/// <summary>
		/// Gets or sets Transformation matrix for layer, default is identity matrix
		/// </summary>
		public double[] Transform { get; set; }
		/// <summary>
		/// Gets or sets Transform anchor point X, absent if no transform specified
		/// </summary>
		public double AnchorX { get; set; }
		/// <summary>
		/// Gets or sets Transform anchor point Y, absent if no transform specified
		/// </summary>
		public double AnchorY { get; set; }
		/// <summary>
		/// Gets or sets Transform anchor point Z, absent if no transform specified
		/// </summary>
		public double AnchorZ { get; set; }
		/// <summary>
		/// Gets or sets Indicates how many time this layer has painted.
		/// </summary>
		public long PaintCount { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether this layer hosts any content, rather than being used for transform/scrolling purposes only.
		/// </summary>
		public bool DrawsContent { get; set; }
		/// <summary>
		/// Gets or sets Set if layer is not visible.
		/// </summary>
		public bool Invisible { get; set; }
		/// <summary>
		/// Gets or sets Rectangles scrolling on main thread only.
		/// </summary>
		public ScrollRect[] ScrollRects { get; set; }
	}
}
