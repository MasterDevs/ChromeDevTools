using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when a <code>Promise</code> is created, updated or garbage collected.
	/// </summary>
	[Event(ProtocolName.Debugger.PromiseUpdated)]
	public class PromiseUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Type of the event.
		/// </summary>
		public string EventType { get; set; }
		/// <summary>
		/// Gets or sets Information about the updated <code>Promise</code>.
		/// </summary>
		public PromiseDetails Promise { get; set; }
	}
}
