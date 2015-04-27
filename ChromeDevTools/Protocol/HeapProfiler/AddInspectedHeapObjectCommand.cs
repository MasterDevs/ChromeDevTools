using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
	/// </summary>
	[Command(ProtocolName.HeapProfiler.AddInspectedHeapObject)]
	public class AddInspectedHeapObjectCommand
	{
		/// <summary>
		/// Gets or sets Heap snapshot object id to be accessible by means of $x command line API.
		/// </summary>
		public string HeapObjectId { get; set; }
	}
}
