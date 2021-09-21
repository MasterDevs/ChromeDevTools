using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class PermissionsPolicyFeatureState
	{
		/// <summary>
		/// Gets or sets Feature
		/// </summary>
		public PermissionsPolicyFeature Feature { get; set; }
		/// <summary>
		/// Gets or sets Allowed
		/// </summary>
		public bool Allowed { get; set; }
		/// <summary>
		/// Gets or sets Locator
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PermissionsPolicyBlockLocator Locator { get; set; }
	}
}
