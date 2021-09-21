using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[Command(ProtocolName.Overlay.SetShowFlexOverlays)]
	[SupportedBy("Chrome")]
	public class SetShowFlexOverlaysCommand: ICommand<SetShowFlexOverlaysCommandResponse>
	{
		/// <summary>
		/// Gets or sets An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public FlexNodeHighlightConfig[] FlexNodeHighlightConfigs { get; set; }
	}
}
