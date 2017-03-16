using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// A structure holding an RGBA color.
	/// </summary>
	[SupportedBy("Chrome")]
	public class RGBA
	{
		/// <summary>
		/// Gets or sets The red component, in the [0-255] range.
		/// </summary>
		public long R { get; set; }
		/// <summary>
		/// Gets or sets The green component, in the [0-255] range.
		/// </summary>
		public long G { get; set; }
		/// <summary>
		/// Gets or sets The blue component, in the [0-255] range.
		/// </summary>
		public long B { get; set; }
		/// <summary>
		/// Gets or sets The alpha component, in the [0-1] range (default: 1).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double A { get; set; }
	}
}
