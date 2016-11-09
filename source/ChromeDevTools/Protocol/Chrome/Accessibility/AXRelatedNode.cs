using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome")]
	public class AXRelatedNode
	{
		/// <summary>
		/// Gets or sets The IDRef value provided, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Idref { get; set; }
		/// <summary>
		/// Gets or sets The BackendNodeId of the related node.
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
