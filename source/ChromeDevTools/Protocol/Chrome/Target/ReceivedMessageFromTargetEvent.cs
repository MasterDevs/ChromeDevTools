using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Notifies about new protocol message from attached target.
	/// </summary>
	[Event(ProtocolName.Target.ReceivedMessageFromTarget)]
	[SupportedBy("Chrome")]
	public class ReceivedMessageFromTargetEvent
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Gets or sets Message
		/// </summary>
		public string Message { get; set; }
	}
}
