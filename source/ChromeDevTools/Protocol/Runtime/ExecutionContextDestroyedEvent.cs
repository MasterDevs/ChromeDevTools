using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Issued when execution context is destroyed.
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextDestroyed)]
	public class ExecutionContextDestroyedEvent
	{
		/// <summary>
		/// Gets or sets Id of the destroyed context
		/// </summary>
		public long ExecutionContextId { get; set; }
	}
}
