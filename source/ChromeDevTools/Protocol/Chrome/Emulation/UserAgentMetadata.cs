using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Used to specify User Agent Cient Hints to emulate. See https://wicg.github.io/ua-client-hints
	/// Missing optional values will be filled in by the target with what it would normally use.
	/// </summary>
	[SupportedBy("Chrome")]
	public class UserAgentMetadata
	{
		/// <summary>
		/// Gets or sets Brands
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public UserAgentBrandVersion[] Brands { get; set; }
		/// <summary>
		/// Gets or sets FullVersion
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FullVersion { get; set; }
		/// <summary>
		/// Gets or sets Platform
		/// </summary>
		public string Platform { get; set; }
		/// <summary>
		/// Gets or sets PlatformVersion
		/// </summary>
		public string PlatformVersion { get; set; }
		/// <summary>
		/// Gets or sets Architecture
		/// </summary>
		public string Architecture { get; set; }
		/// <summary>
		/// Gets or sets Model
		/// </summary>
		public string Model { get; set; }
		/// <summary>
		/// Gets or sets Mobile
		/// </summary>
		public bool Mobile { get; set; }
	}
}
