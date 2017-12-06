using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Issued when execution context is destroyed.
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextDestroyed)]
	[SupportedBy("Chrome")]
	public class ExecutionContextDestroyedEvent
	{
		/// <summary>
		/// Gets or sets Id of the destroyed context
		/// </summary>
		public long ExecutionContextId { get; set; }
	}
}
