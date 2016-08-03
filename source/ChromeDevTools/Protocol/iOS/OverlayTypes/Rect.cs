using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	/// A rectangle specified by a reference coordinate and width/height offsets.
	/// </summary>
	[SupportedBy("iOS")]
	public class Rect
	{
		/// <summary>
		/// Gets or sets X
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets Width
		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Gets or sets Height
		/// </summary>
		public double Height { get; set; }
	}
}
