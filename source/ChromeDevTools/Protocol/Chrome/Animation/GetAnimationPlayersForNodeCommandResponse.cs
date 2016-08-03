using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Returns animation players relevant to the node.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.GetAnimationPlayersForNode)]
	[SupportedBy("Chrome")]
	public class GetAnimationPlayersForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of animation players.
		/// </summary>
		public AnimationPlayer[] AnimationPlayers { get; set; }
	}
}
