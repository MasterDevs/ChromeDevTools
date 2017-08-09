using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Issued when console API was called.
	/// </summary>
	[Event(ProtocolName.Runtime.ConsoleAPICalled)]
	[SupportedBy("Chrome")]
	public class ConsoleAPICalledEvent
	{
		/// <summary>
		/// Gets or sets Type of the call.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Call arguments.
		/// </summary>
		public RemoteObject[] Args { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the context where the call was made.
		/// </summary>
		public long ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or sets Call timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Stack trace captured when the call was made.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StackTrace StackTrace { get; set; }
	}
}
