using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Inspector
{
	[Event(ProtocolName.Inspector.Inspect)]
	[SupportedBy("Chrome")]
	public class InspectEvent
	{
		/// <summary>
		/// Gets or sets Object
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
		/// <summary>
		/// Gets or sets Hints
		/// </summary>
		public object Hints { get; set; }
	}
}
