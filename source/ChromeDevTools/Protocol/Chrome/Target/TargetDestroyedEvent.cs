using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Issued when a target is destroyed.
	/// </summary>
	[Event(ProtocolName.Target.TargetDestroyed)]
	[SupportedBy("Chrome")]
	public class TargetDestroyedEvent
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
