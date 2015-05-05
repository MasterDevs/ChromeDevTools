using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	[Event(ProtocolName.Power.DataAvailable)]
	public class DataAvailableEvent
	{
		/// <summary>
		/// Gets or sets List of power events.
		/// </summary>
		public PowerEvent[] Value { get; set; }
	}
}
