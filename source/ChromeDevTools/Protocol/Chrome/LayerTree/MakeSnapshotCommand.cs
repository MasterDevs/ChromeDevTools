using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Returns the layer snapshot identifier.
	/// </summary>
	[Command(ProtocolName.LayerTree.MakeSnapshot)]
	[SupportedBy("Chrome")]
	public class MakeSnapshotCommand: ICommand<MakeSnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or sets The id of the layer.
		/// </summary>
		public string LayerId { get; set; }
	}
}
