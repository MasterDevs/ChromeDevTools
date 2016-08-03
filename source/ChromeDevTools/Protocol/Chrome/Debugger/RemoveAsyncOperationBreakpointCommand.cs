using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Removes AsyncOperation breakpoint.
	/// </summary>
	[Command(ProtocolName.Debugger.RemoveAsyncOperationBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveAsyncOperationBreakpointCommand
	{
		/// <summary>
		/// Gets or sets ID of the async operation to remove breakpoint for.
		/// </summary>
		public long OperationId { get; set; }
	}
}
