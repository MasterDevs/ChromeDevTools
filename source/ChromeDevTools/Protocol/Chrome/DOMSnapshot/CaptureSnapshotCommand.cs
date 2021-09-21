using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Returns a document snapshot, including the full DOM tree of the root node (including iframes,
	/// template contents, and imported documents) in a flattened array, as well as layout and
	/// white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is
	/// flattened.
	/// </summary>
	[Command(ProtocolName.DOMSnapshot.CaptureSnapshot)]
	[SupportedBy("Chrome")]
	public class CaptureSnapshotCommand: ICommand<CaptureSnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whitelist of computed styles to return.
		/// </summary>
		public string[] ComputedStyles { get; set; }
		/// <summary>
		/// Gets or sets Whether to include layout object paint orders into the snapshot.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludePaintOrder { get; set; }
		/// <summary>
		/// Gets or sets Whether to include DOM rectangles (offsetRects, clientRects, scrollRects) into the snapshot
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeDOMRects { get; set; }
		/// <summary>
		/// Gets or sets Whether to include blended background colors in the snapshot (default: false).
		/// Blended background color is achieved by blending background colors of all elements
		/// that overlap with the current element.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeBlendedBackgroundColors { get; set; }
		/// <summary>
		/// Gets or sets Whether to include text color opacity in the snapshot (default: false).
		/// An element might have the opacity property set that affects the text color of the element.
		/// The final text color opacity is computed based on the opacity of all overlapping elements.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeTextColorOpacities { get; set; }
	}
}
