using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Indicates whether a frame has been identified as an ad and why.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AdFrameStatus
	{
		/// <summary>
		/// Gets or sets AdFrameType
		/// </summary>
		public AdFrameType AdFrameType { get; set; }
		/// <summary>
		/// Gets or sets Explanations
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AdFrameExplanation[] Explanations { get; set; }
	}
}
