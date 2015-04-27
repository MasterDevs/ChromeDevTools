using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetHeapObjectId)]
	public class GetHeapObjectIdCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to get heap object id for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
