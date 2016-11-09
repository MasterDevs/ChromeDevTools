using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Key.
	/// </summary>
	[SupportedBy("iOS")]
	public class Key
	{
		/// <summary>
		/// Gets or sets Key type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Number value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Number { get; set; }
		/// <summary>
		/// Gets or sets String value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string String { get; set; }
		/// <summary>
		/// Gets or sets Date value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Date { get; set; }
		/// <summary>
		/// Gets or sets Array value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key[] Array { get; set; }
	}
}
