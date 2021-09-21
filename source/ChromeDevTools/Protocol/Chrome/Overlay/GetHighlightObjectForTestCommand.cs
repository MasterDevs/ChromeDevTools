using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// For testing.
	/// </summary>
	[Command(ProtocolName.Overlay.GetHighlightObjectForTest)]
	[SupportedBy("Chrome")]
	public class GetHighlightObjectForTestCommand: ICommand<GetHighlightObjectForTestCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to get highlight object for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Whether to include distance info.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeDistance { get; set; }
		/// <summary>
		/// Gets or sets Whether to include style info.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeStyle { get; set; }
		/// <summary>
		/// Gets or sets The color format to get config with (default: hex).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ColorFormat { get; set; }
		/// <summary>
		/// Gets or sets Whether to show accessibility info (default: true).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowAccessibilityInfo { get; set; }
	}
}
