using ChromeDevTools;

namespace ChromeDevTools.Protocol.Profiler
{
	[Event(ProtocolName.Profiler.ConsoleProfileFinished)]
	public class ConsoleProfileFinishedEvent
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Location of console.profileEnd().
		/// </summary>
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Gets or sets Profile
		/// </summary>
		public CPUProfile Profile { get; set; }
		/// <summary>
		/// Gets or sets Profile title passed as argunet to console.profile().
		/// </summary>
		public string Title { get; set; }
	}
}
