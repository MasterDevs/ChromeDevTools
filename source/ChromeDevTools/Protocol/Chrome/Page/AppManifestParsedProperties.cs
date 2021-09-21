using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Parsed app manifest properties.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AppManifestParsedProperties
	{
		/// <summary>
		/// Gets or sets Computed scope value
		/// </summary>
		public string Scope { get; set; }
	}
}
