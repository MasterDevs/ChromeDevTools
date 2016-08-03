using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Rectangle.
	/// </summary>
	[SupportedBy("Chrome")]
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
