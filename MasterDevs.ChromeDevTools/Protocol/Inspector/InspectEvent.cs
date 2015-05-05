using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	[Event(ProtocolName.Inspector.Inspect)]
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
