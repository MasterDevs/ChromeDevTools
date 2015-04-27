using ChromeDevTools;

namespace ChromeDevTools.Protocol.Profiler
{
	/// <summary>
	/// Sent when new profile recodring is started using console.profile() call.
	/// </summary>
	[Event(ProtocolName.Profiler.ConsoleProfileStarted)]
	public class ConsoleProfileStartedEvent
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Location of console.profile().
		/// </summary>
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Gets or sets Profile title passed as argument to console.profile().
		/// </summary>
		public string Title { get; set; }
	}
}
