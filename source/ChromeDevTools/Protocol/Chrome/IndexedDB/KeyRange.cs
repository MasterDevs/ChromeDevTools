using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Key range.
	/// </summary>
	[SupportedBy("Chrome")]
	public class KeyRange
	{
		/// <summary>
		/// Gets or sets Lower bound.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key Lower { get; set; }
		/// <summary>
		/// Gets or sets Upper bound.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key Upper { get; set; }
		/// <summary>
		/// Gets or sets If true lower bound is open.
		/// </summary>
		public bool LowerOpen { get; set; }
		/// <summary>
		/// Gets or sets If true upper bound is open.
		/// </summary>
		public bool UpperOpen { get; set; }
	}
}
