using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Returns a document snapshot, including the full DOM tree of the root node (including iframes, template contents, and imported documents) in a flattened array, as well as layout and white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is flattened. 
	/// </summary>
	[Command(ProtocolName.DOMSnapshot.GetSnapshot)]
	[SupportedBy("Chrome")]
	public class GetSnapshotCommand: ICommand<GetSnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whitelist of computed styles to return.
		/// </summary>
		public string[] ComputedStyleWhitelist { get; set; }
	}
}
