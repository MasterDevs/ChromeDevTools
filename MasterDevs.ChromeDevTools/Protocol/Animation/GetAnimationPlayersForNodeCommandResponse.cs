using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Returns animation players relevant to the node.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.GetAnimationPlayersForNode)]
	public class GetAnimationPlayersForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of animation players.
		/// </summary>
		public AnimationPlayer[] AnimationPlayers { get; set; }
	}
}
