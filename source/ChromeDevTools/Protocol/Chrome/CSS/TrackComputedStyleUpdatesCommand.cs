using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Starts tracking the given computed styles for updates. The specified array of properties
	/// replaces the one previously specified. Pass empty array to disable tracking.
	/// Use takeComputedStyleUpdates to retrieve the list of nodes that had properties modified.
	/// The changes to computed style properties are only tracked for nodes pushed to the front-end
	/// by the DOM agent. If no changes to the tracked properties occur after the node has been pushed
	/// to the front-end, no updates will be issued for the node.
	/// </summary>
	[Command(ProtocolName.CSS.TrackComputedStyleUpdates)]
	[SupportedBy("Chrome")]
	public class TrackComputedStyleUpdatesCommand: ICommand<TrackComputedStyleUpdatesCommandResponse>
	{
		/// <summary>
		/// Gets or sets PropertiesToTrack
		/// </summary>
		public CSSComputedStyleProperty[] PropertiesToTrack { get; set; }
	}
}
