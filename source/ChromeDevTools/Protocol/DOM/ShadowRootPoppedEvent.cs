using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when shadow root is popped from the element.
	/// </summary>
	[Event(ProtocolName.DOM.ShadowRootPopped)]
	public class ShadowRootPoppedEvent
	{
		/// <summary>
		/// Gets or sets Host element id.
		/// </summary>
		public long HostId { get; set; }
		/// <summary>
		/// Gets or sets Shadow root id.
		/// </summary>
		public long RootId { get; set; }
	}
}
