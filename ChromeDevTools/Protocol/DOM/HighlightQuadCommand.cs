using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightQuad)]
	public class HighlightQuadCommand
	{
		/// <summary>
		/// Gets or sets Quad to highlight
		/// </summary>
		public double[] Quad { get; set; }
		/// <summary>
		/// Gets or sets The highlight fill color (default: transparent).
		/// </summary>
		public RGBA Color { get; set; }
		/// <summary>
		/// Gets or sets The highlight outline color (default: transparent).
		/// </summary>
		public RGBA OutlineColor { get; set; }
	}
}
