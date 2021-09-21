using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class FlexNodeHighlightConfig
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance of flex containers.
		/// </summary>
		public FlexContainerHighlightConfig FlexContainerHighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
