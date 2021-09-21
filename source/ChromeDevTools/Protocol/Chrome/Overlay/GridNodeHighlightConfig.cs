using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Configurations for Persistent Grid Highlight
	/// </summary>
	[SupportedBy("Chrome")]
	public class GridNodeHighlightConfig
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance.
		/// </summary>
		public GridHighlightConfig GridHighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
