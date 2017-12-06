using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetLayoutMetrics)]
	[SupportedBy("Chrome")]
	public class GetLayoutMetricsCommandResponse
	{
		/// <summary>
		/// Gets or sets Metrics relating to the layout viewport.
		/// </summary>
		public LayoutViewport LayoutViewport { get; set; }
		/// <summary>
		/// Gets or sets Metrics relating to the visual viewport.
		/// </summary>
		public VisualViewport VisualViewport { get; set; }
		/// <summary>
		/// Gets or sets Size of scrollable area.
		/// </summary>
		public DOM.Rect ContentSize { get; set; }
	}
}
