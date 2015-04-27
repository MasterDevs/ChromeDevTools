using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetObjectByHeapObjectId)]
	public class GetObjectByHeapObjectIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Evaluation result.
		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
	}
}
