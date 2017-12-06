using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns requested styles for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetMatchedStylesForNode)]
	[SupportedBy("iOS")]
	public class GetMatchedStylesForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets CSS rules matching this node, from all applicable stylesheets.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RuleMatch[] MatchedCSSRules { get; set; }
		/// <summary>
		/// Gets or sets Pseudo style matches for this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PseudoIdMatches[] PseudoElements { get; set; }
		/// <summary>
		/// Gets or sets A chain of inherited styles (from the immediate node parent up to the DOM tree root).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InheritedStyleEntry[] Inherited { get; set; }
	}
}
