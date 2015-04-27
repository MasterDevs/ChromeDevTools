using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Console message.
	/// </summary>
	public class ConsoleMessage
	{
		/// <summary>
		/// Gets or sets Message source.
		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Gets or sets Message severity.
		/// </summary>
		public string Level { get; set; }
		/// <summary>
		/// Gets or sets Message text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Console message type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Script ID of the message origin.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets URL of the message origin.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Line number in the resource that generated this message.
		/// </summary>
		public long Line { get; set; }
		/// <summary>
		/// Gets or sets Column number in the resource that generated this message.
		/// </summary>
		public long Column { get; set; }
		/// <summary>
		/// Gets or sets Repeat count for repeated messages.
		/// </summary>
		public long RepeatCount { get; set; }
		/// <summary>
		/// Gets or sets Message parameters in case of the formatted message.
		/// </summary>
		public Runtime.RemoteObject[] Parameters { get; set; }
		/// <summary>
		/// Gets or sets JavaScript stack trace for assertions and error messages.
		/// </summary>
		public CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Asynchronous JavaScript stack trace that preceded this message, if available.
		/// </summary>
		public AsyncStackTrace AsyncStackTrace { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the network request associated with this message.
		/// </summary>
		public string NetworkRequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp, when this message was fired.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the context where this message was created
		/// </summary>
		public long ExecutionContextId { get; set; }
	}
}
