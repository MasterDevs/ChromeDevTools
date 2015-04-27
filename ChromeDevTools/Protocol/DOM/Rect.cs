using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Rectangle.
	/// </summary>
	public class Rect
	{
		/// <summary>
		/// Gets or sets X coordinate
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets Rectangle width
		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Gets or sets Rectangle height
		/// </summary>
		public double Height { get; set; }
	}
}
