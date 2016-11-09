using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Box model.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BoxModel
	{
		/// <summary>
		/// Gets or sets Content box
		/// </summary>
		public double[] Content { get; set; }
		/// <summary>
		/// Gets or sets Padding box
		/// </summary>
		public double[] Padding { get; set; }
		/// <summary>
		/// Gets or sets Border box
		/// </summary>
		public double[] Border { get; set; }
		/// <summary>
		/// Gets or sets Margin box
		/// </summary>
		public double[] Margin { get; set; }
		/// <summary>
		/// Gets or sets Node width
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Node height
		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Gets or sets Shape outside coordinates
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ShapeOutsideInfo ShapeOutside { get; set; }
	}
}
