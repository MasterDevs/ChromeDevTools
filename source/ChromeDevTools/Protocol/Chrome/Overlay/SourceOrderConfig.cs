using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Configuration data for drawing the source order of an elements children.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SourceOrderConfig
	{
		/// <summary>
		/// Gets or sets the color to outline the givent element in.
		/// </summary>
		public DOM.RGBA ParentOutlineColor { get; set; }
		/// <summary>
		/// Gets or sets the color to outline the child elements in.
		/// </summary>
		public DOM.RGBA ChildOutlineColor { get; set; }
	}
}
