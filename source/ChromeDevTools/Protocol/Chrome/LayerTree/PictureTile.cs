using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Serialized fragment of layer picture along with its offset within the layer.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PictureTile
	{
		/// <summary>
		/// Gets or sets Offset from owning layer left boundary
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Offset from owning layer top boundary
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets Base64-encoded snapshot data.
		/// </summary>
		public string Picture { get; set; }
	}
}
