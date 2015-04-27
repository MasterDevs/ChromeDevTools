using ChromeDevTools;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Fired when a visible page viewport has changed. Only fired when device metrics are overridden.
	/// </summary>
	[Event(ProtocolName.Emulation.ViewportChanged)]
	public class ViewportChangedEvent
	{
		/// <summary>
		/// Gets or sets Viewport description.
		/// </summary>
		public Viewport Viewport { get; set; }
	}
}
