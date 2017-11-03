using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Issued when new execution context is created.
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextCreated)]
	[SupportedBy("iOS")]
	public class ExecutionContextCreatedEvent
	{
		/// <summary>
		/// Gets or sets A newly created execution contex.
		/// </summary>
		public ExecutionContextDescription Context { get; set; }
	}
}
