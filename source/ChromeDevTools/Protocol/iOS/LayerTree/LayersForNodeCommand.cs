using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// Returns the layer tree structure of the current page.
	/// </summary>
	[Command(ProtocolName.LayerTree.LayersForNode)]
	[SupportedBy("iOS")]
	public class LayersForNodeCommand
	{
		/// <summary>
		/// Gets or sets Root of the subtree for which we want to gather layers.
		/// </summary>
		public long NodeId { get; set; }
	}
}
