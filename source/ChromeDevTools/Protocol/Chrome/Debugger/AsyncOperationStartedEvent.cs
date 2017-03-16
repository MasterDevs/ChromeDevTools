using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Fired when an async operation is scheduled (while in a debugger stepping session).
	/// </summary>
	[Event(ProtocolName.Debugger.AsyncOperationStarted)]
	[SupportedBy("Chrome")]
	public class AsyncOperationStartedEvent
	{
		/// <summary>
		/// Gets or sets Information about the async operation.
		/// </summary>
		public AsyncOperation Operation { get; set; }
	}
}
