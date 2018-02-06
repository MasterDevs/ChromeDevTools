using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Capture a snapshot of the specified node that does not include unrelated layers.
	/// </summary>
	[Command(ProtocolName.Page.SnapshotNode)]
	[SupportedBy("iOS")]
	public class SnapshotNodeCommand: ICommand<SnapshotNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to snapshot.
		/// </summary>
		public long NodeId { get; set; }
	}
}
