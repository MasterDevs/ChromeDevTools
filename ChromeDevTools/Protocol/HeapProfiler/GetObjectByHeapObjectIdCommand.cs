using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetObjectByHeapObjectId)]
	public class GetObjectByHeapObjectIdCommand
	{
		/// <summary>
		/// Gets or sets ObjectId
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
