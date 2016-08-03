using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Returns animation players relevant to the node.
	/// </summary>
	[Command(ProtocolName.Animation.GetAnimationPlayersForNode)]
	[SupportedBy("Chrome")]
	public class GetAnimationPlayersForNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get animation players for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Include animations from elements subtree.
		/// </summary>
		public bool IncludeSubtreeAnimations { get; set; }
	}
}
