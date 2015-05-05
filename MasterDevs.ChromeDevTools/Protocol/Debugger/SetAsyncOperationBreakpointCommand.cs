using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets breakpoint on AsyncOperation callback handler.
	/// </summary>
	[Command(ProtocolName.Debugger.SetAsyncOperationBreakpoint)]
	public class SetAsyncOperationBreakpointCommand
	{
		/// <summary>
		/// Gets or sets ID of the async operation to set breakpoint for.
		/// </summary>
		public long OperationId { get; set; }
	}
}
