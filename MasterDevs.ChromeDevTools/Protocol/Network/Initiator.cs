using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Information about the request initiator.
	/// </summary>
	public class Initiator
	{
		/// <summary>
		/// Gets or sets Type of this initiator.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Initiator JavaScript stack trace, set for Script only.
		/// </summary>
		public Console.CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Initiator URL, set for Parser type only.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Initiator line number, set for Parser type only.
		/// </summary>
		public double LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Initiator asynchronous JavaScript stack trace, if available.
		/// </summary>
		public Console.AsyncStackTrace AsyncStackTrace { get; set; }
	}
}
