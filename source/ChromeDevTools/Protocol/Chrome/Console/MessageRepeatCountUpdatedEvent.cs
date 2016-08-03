using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Is not issued. Will be gone in the future versions of the protocol.
	/// </summary>
	[Event(ProtocolName.Console.MessageRepeatCountUpdated)]
	[SupportedBy("Chrome")]
	public class MessageRepeatCountUpdatedEvent
	{
		/// <summary>
		/// Gets or sets New repeat count value.
		/// </summary>
		public long Count { get; set; }
		/// <summary>
		/// Gets or sets Timestamp of most recent message in batch.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
