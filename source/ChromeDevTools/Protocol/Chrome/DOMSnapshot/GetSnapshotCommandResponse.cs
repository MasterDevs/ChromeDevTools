using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Returns a document snapshot, including the full DOM tree of the root node (including iframes, template contents, and imported documents) in a flattened array, as well as layout and white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is flattened. 
	/// </summary>
	[CommandResponse(ProtocolName.DOMSnapshot.GetSnapshot)]
	[SupportedBy("Chrome")]
	public class GetSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The nodes in the DOM tree. The DOMNode at index 0 corresponds to the root document.
		/// </summary>
		public DOMNode[] DomNodes { get; set; }
		/// <summary>
		/// Gets or sets The nodes in the layout tree.
		/// </summary>
		public LayoutTreeNode[] LayoutTreeNodes { get; set; }
		/// <summary>
		/// Gets or sets Whitelisted ComputedStyle properties for each node in the layout tree.
		/// </summary>
		public ComputedStyle[] ComputedStyles { get; set; }
	}
}
