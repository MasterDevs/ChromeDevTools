using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Issued when attached to target because of auto-attach or <code>attachToTarget</code> command.
	/// </summary>
	[Event(ProtocolName.Target.AttachedToTarget)]
	[SupportedBy("Chrome")]
	public class AttachedToTargetEvent
	{
		/// <summary>
		/// Gets or sets TargetInfo
		/// </summary>
		public TargetInfo TargetInfo { get; set; }
		/// <summary>
		/// Gets or sets WaitingForDebugger
		/// </summary>
		public bool WaitingForDebugger { get; set; }
	}
}
