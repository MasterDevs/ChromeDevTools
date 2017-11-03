using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetHeapObjectId)]
	[SupportedBy("Chrome")]
	public class GetHeapObjectIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the heap snapshot object corresponding to the passed remote object id.
		/// </summary>
		public string HeapSnapshotObjectId { get; set; }
	}
}
