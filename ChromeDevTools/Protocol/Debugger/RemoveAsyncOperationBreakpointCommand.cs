using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Removes AsyncOperation breakpoint.
	/// </summary>
	[Command(ProtocolName.Debugger.RemoveAsyncOperationBreakpoint)]
	public class RemoveAsyncOperationBreakpointCommand
	{
		/// <summary>
		/// Gets or sets ID of the async operation to remove breakpoint for.
		/// </summary>
		public long OperationId { get; set; }
	}
}
