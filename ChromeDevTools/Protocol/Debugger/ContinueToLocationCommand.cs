using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>
	[Command(ProtocolName.Debugger.ContinueToLocation)]
	public class ContinueToLocationCommand
	{
		/// <summary>
		/// Gets or sets Location to continue to.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets Allows breakpoints at the intemediate positions inside statements.
		/// </summary>
		public bool InterstatementLocation { get; set; }
	}
}
