using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Viewport for capturing screenshot.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Viewport
	{
		/// <summary>
		/// Gets or sets X offset in CSS pixels.
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y offset in CSS pixels
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets Rectangle width in CSS pixels
		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Gets or sets Rectangle height in CSS pixels
		/// </summary>
		public double Height { get; set; }
		/// <summary>
		/// Gets or sets Page scale factor.
		/// </summary>
		public double Scale { get; set; }
	}
}
