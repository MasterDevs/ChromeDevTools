using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// Returns the layer tree structure of the current page.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.LayersForNode)]
	[SupportedBy("iOS")]
	public class LayersForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Child layers.
		/// </summary>
		public Layer[] Layers { get; set; }
	}
}
