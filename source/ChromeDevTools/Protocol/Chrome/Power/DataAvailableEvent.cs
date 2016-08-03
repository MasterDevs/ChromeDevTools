using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Power
{
	[Event(ProtocolName.Power.DataAvailable)]
	[SupportedBy("Chrome")]
	public class DataAvailableEvent
	{
		/// <summary>
		/// Gets or sets List of power events.
		/// </summary>
		public PowerEvent[] Value { get; set; }
	}
}
