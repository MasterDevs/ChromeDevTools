using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	/// A single region in a flow thread.
	/// </summary>
	[SupportedBy("iOS")]
	public class Region
	{
		/// <summary>
		/// Gets or sets BorderQuad
		/// </summary>
		public Point[] BorderQuad { get; set; }
		/// <summary>
		/// Gets or sets IncomingQuad
		/// </summary>
		public Point[] IncomingQuad { get; set; }
		/// <summary>
		/// Gets or sets OutgoingQuad
		/// </summary>
		public Point[] OutgoingQuad { get; set; }
		/// <summary>
		/// Gets or sets IsHighlighted
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsHighlighted { get; set; }
	}
}
