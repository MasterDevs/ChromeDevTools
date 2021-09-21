using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[SupportedBy("Chrome")]
	public class DisplayFeature
	{
		/// <summary>
		/// Gets or sets Orientation of a display feature in relation to screen
		/// </summary>
		public string Orientation { get; set; }
		/// <summary>
		/// Gets or sets The offset from the screen origin in either the x (for vertical
		/// orientation) or y (for horizontal orientation) direction.
		/// </summary>
		public long Offset { get; set; }
		/// <summary>
		/// Gets or sets A display feature may mask content such that it is not physically
		/// displayed - this length along with the offset describes this area.
		/// A display feature that only splits content will have a 0 mask_length.
		/// </summary>
		public long MaskLength { get; set; }
	}
}
