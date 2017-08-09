using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
	/// </summary>
	[Command(ProtocolName.Accessibility.GetPartialAXTree)]
	[SupportedBy("Chrome")]
	public class GetPartialAXTreeCommand
	{
		/// <summary>
		/// Gets or sets ID of node to get the partial accessibility tree for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Whether to fetch this nodes ancestors, siblings and children. Defaults to true.
		/// </summary>
		public bool FetchRelatives { get; set; }
	}
}
