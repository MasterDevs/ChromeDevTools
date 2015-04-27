using ChromeDevTools;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Issued when new execution context is created.
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextCreated)]
	public class ExecutionContextCreatedEvent
	{
		/// <summary>
		/// Gets or sets A newly created execution contex.
		/// </summary>
		public ExecutionContextDescription Context { get; set; }
	}
}
