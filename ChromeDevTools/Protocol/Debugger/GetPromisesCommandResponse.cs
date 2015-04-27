using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns detailed information about all <code>Promise</code>s that were created or updated after the <code>enablePromiseTracker</code> command, and have not been garbage collected yet.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetPromises)]
	public class GetPromisesCommandResponse
	{
		/// <summary>
		/// Gets or sets Information about stored promises.
		/// </summary>
		public PromiseDetails[] Promises { get; set; }
	}
}
