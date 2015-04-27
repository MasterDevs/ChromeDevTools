using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>
	[Command(ProtocolName.LayerTree.CompositingReasons)]
	public class CompositingReasonsCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer for which we want to get the reasons it was composited.
		/// </summary>
		public string LayerId { get; set; }
	}
}
