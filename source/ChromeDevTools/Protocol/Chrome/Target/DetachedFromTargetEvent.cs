using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Issued when detached from target for any reason (including <code>detachFromTarget</code> command).
	/// </summary>
	[Event(ProtocolName.Target.DetachedFromTarget)]
	[SupportedBy("Chrome")]
	public class DetachedFromTargetEvent
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
