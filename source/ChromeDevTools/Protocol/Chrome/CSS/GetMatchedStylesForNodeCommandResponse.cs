using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
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
		/// Gets or sets Inline style for the specified DOM node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle InlineStyle { get; set; }
		/// <summary>
		/// Gets or sets Attribute-defined element style (e.g. resulting from "width=20 height=100%").
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle AttributesStyle { get; set; }
		/// <summary>
		/// Gets or sets CSS rules matching this node, from all applicable stylesheets.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RuleMatch[] MatchedCSSRules { get; set; }
		/// <summary>
		/// Gets or sets Pseudo style matches for this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PseudoElementMatches[] PseudoElements { get; set; }
		/// <summary>
		/// Gets or sets A chain of inherited styles (from the immediate node parent up to the DOM tree root).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InheritedStyleEntry[] Inherited { get; set; }
		/// <summary>
		/// Gets or sets A list of CSS keyframed animations matching this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSKeyframesRule[] CssKeyframesRules { get; set; }
	}
}
