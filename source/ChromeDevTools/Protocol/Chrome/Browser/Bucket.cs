using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Chrome histogram bucket.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Bucket
	{
		/// <summary>
		/// Gets or sets Minimum value (inclusive).
		/// </summary>
		public long Low { get; set; }
		/// <summary>
		/// Gets or sets Maximum value (exclusive).
		/// </summary>
		public long High { get; set; }
		/// <summary>
		/// Gets or sets Number of samples.
		/// </summary>
		public long Count { get; set; }
	}
}
