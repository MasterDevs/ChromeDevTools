using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetHeapObjectId)]
	public class GetHeapObjectIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the heap snapshot object corresponding to the passed remote object id.
		/// </summary>
		public string HeapSnapshotObjectId { get; set; }
	}
}
