using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns requested styles for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetMatchedStylesForNode)]
	[SupportedBy("Chrome")]
	public class GetMatchedStylesForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets CSS rules matching this node, from all applicable stylesheets.
		/// </summary>
		public RuleMatch[] MatchedCSSRules { get; set; }
		/// <summary>
		/// Gets or sets Pseudo style matches for this node.
		/// </summary>
		public PseudoIdMatches[] PseudoElements { get; set; }
		/// <summary>
		/// Gets or sets A chain of inherited styles (from the immediate node parent up to the DOM tree root).
		/// </summary>
		public InheritedStyleEntry[] Inherited { get; set; }
	}
}
