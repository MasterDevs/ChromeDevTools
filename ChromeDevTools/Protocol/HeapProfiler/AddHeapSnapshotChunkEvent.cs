using ChromeDevTools;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.AddHeapSnapshotChunk)]
	public class AddHeapSnapshotChunkEvent
	{
		/// <summary>
		/// Gets or sets Chunk
		/// </summary>
		public string Chunk { get; set; }
	}
}
