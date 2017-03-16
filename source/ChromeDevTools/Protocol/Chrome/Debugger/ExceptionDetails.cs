using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Detailed information on exception (or error) that was thrown during script compilation or execution.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ExceptionDetails
	{
		/// <summary>
		/// Gets or sets Exception text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets URL of the message origin.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Script ID of the message origin.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Line number in the resource that generated this message.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Line { get; set; }
		/// <summary>
		/// Gets or sets Column number in the resource that generated this message.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Column { get; set; }
		/// <summary>
		/// Gets or sets JavaScript stack trace for assertions and error messages.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Console.CallFrame[] StackTrace { get; set; }
	}
}
