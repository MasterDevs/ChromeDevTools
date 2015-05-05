using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Requests information about platform fonts which we used to render child TextNodes in the given node.
	/// </summary>
	[Command(ProtocolName.CSS.GetPlatformFontsForNode)]
	public class GetPlatformFontsForNodeCommand
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
