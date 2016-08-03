using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Fired when an async operation is completed (while in a debugger stepping session).
	/// </summary>
	[Event(ProtocolName.Debugger.AsyncOperationCompleted)]
	[SupportedBy("Chrome")]
	public class AsyncOperationCompletedEvent
	{
		/// <summary>
		/// Gets or sets ID of the async operation that was completed.
		/// </summary>
		public long Id { get; set; }
	}
}
