using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Chrome histogram.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Histogram
	{
		/// <summary>
		/// Gets or sets Name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Sum of sample values.
		/// </summary>
		public long Sum { get; set; }
		/// <summary>
		/// Gets or sets Total number of samples.
		/// </summary>
		public long Count { get; set; }
		/// <summary>
		/// Gets or sets Buckets.
		/// </summary>
		public Bucket[] Buckets { get; set; }
	}
}
