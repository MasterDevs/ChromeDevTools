using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.AddHeapSnapshotChunk)]
	[SupportedBy("Chrome")]
	public class AddHeapSnapshotChunkEvent
	{
		/// <summary>
		/// Gets or sets Chunk
		/// </summary>
		public string Chunk { get; set; }
	}
}
