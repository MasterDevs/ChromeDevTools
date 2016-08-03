using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns node id at given location.
	/// </summary>
	[Command(ProtocolName.DOM.GetNodeForLocation)]
	[SupportedBy("Chrome")]
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
