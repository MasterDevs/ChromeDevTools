using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	[CommandResponse(ProtocolName.LayerTree.ProfileSnapshot)]
	public class ProfileSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The array of paint profiles, one per run.
		/// </summary>
		public double[][] Timings { get; set; }
	}
}
