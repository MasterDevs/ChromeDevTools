using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Highlight multiple elements with the CSS Grid overlay.
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowGridOverlays)]
	[SupportedBy("Chrome")]
	public class SetShowGridOverlaysCommand: ICommand<SetShowGridOverlaysCommandResponse>
	{
		/// <summary>
		/// Gets or sets An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public GridNodeHighlightConfig[] GridNodeHighlightConfigs { get; set; }
	}
}
