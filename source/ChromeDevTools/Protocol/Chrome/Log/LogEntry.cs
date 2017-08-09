using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Log entry.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LogEntry
	{
		/// <summary>
		/// Gets or sets Log entry source.
		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Gets or sets Log entry severity.
		/// </summary>
		public string Level { get; set; }
		/// <summary>
		/// Gets or sets Logged text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Timestamp when this entry was added.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets URL of the resource if known.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Line number in the resource.
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets JavaScript stack trace.
		/// </summary>
		public Runtime.StackTrace StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the network request associated with this entry.
		/// </summary>
		public string NetworkRequestId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the worker associated with this entry.
		/// </summary>
		public string WorkerId { get; set; }
	}
}
