using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Key.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Key
	{
		/// <summary>
		/// Gets or sets Key type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Number value.
		/// </summary>
		public double Number { get; set; }
		/// <summary>
		/// Gets or sets String value.
		/// </summary>
		public string String { get; set; }
		/// <summary>
		/// Gets or sets Date value.
		/// </summary>
		public double Date { get; set; }
		/// <summary>
		/// Gets or sets Array value.
		/// </summary>
		public Key[] Array { get; set; }
	}
}
