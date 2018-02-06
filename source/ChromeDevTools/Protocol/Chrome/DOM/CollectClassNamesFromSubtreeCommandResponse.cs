using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Collects class names for the node with given id and all of it's child nodes.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.CollectClassNamesFromSubtree)]
	[SupportedBy("Chrome")]
	public class CollectClassNamesFromSubtreeCommandResponse
	{
		/// <summary>
		/// Gets or sets Class name list.
		/// </summary>
		public string[] ClassNames { get; set; }
	}
}
