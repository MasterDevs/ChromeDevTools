using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ContainerQueryContainerHighlightConfig
	{
		/// <summary>
		/// Gets or sets The style of the container border.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle ContainerBorder { get; set; }
		/// <summary>
		/// Gets or sets The style of the descendants' borders.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle DescendantBorder { get; set; }
	}
}
