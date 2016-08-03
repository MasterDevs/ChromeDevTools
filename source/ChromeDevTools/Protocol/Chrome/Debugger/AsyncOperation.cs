using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Information about the async operation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AsyncOperation
	{
		/// <summary>
		/// Gets or sets Unique id of the async operation.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets String description of the async operation.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Stack trace where async operation was scheduled.
		/// </summary>
		public Console.CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Asynchronous stack trace where async operation was scheduled, if available.
		/// </summary>
		public Console.AsyncStackTrace AsyncStackTrace { get; set; }
	}
}
