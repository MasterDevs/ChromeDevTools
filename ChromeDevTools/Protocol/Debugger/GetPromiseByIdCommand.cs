using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns <code>Promise</code> with specified ID.
	/// </summary>
	[Command(ProtocolName.Debugger.GetPromiseById)]
	public class GetPromiseByIdCommand
	{
		/// <summary>
		/// Gets or sets PromiseId
		/// </summary>
		public long PromiseId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
