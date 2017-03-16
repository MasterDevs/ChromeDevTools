using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	/// Key path.
	/// </summary>
	[SupportedBy("iOS")]
	public class KeyPath
	{
		/// <summary>
		/// Gets or sets Key path type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets String value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string String { get; set; }
		/// <summary>
		/// Gets or sets Array value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Array { get; set; }
	}
}
