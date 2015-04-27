using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Enables or disables async call stacks tracking.
	/// </summary>
	[Command(ProtocolName.Debugger.SetAsyncCallStackDepth)]
	public class SetAsyncCallStackDepthCommand
	{
		/// <summary>
		/// Gets or sets Maximum depth of async call stacks. Setting to <code>0</code> will effectively disable collecting async call stacks (default).
		/// </summary>
		public long MaxDepth { get; set; }
	}
}
