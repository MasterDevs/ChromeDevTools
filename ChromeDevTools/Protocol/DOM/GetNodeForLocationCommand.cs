using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns node id at given location.
	/// </summary>
	[Command(ProtocolName.DOM.GetNodeForLocation)]
	public class GetNodeForLocationCommand
	{
		/// <summary>
		/// Gets or sets X coordinate.
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate.
		/// </summary>
		public long Y { get; set; }
	}
}
