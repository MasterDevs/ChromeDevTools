using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Console message.
	/// </summary>
	[SupportedBy("iOS")]
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
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets URL of the message origin.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Line number in the resource that generated this message.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Line { get; set; }
		/// <summary>
		/// Gets or sets Column number on the line in the resource that generated this message.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Column { get; set; }
		/// <summary>
		/// Gets or sets Repeat count for repeated messages.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RepeatCount { get; set; }
		/// <summary>
		/// Gets or sets Message parameters in case of the formatted message.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject[] Parameters { get; set; }
		/// <summary>
		/// Gets or sets JavaScript stack trace for assertions and error messages.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the network request associated with this message.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NetworkRequestId { get; set; }
	}
}
