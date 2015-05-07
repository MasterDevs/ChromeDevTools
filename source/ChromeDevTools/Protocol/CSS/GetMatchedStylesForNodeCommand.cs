using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns requested styles for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetMatchedStylesForNode)]
	public class GetMatchedStylesForNodeCommand
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Whether to exclude pseudo styles (default: false).
		/// </summary>
		public bool ExcludePseudo { get; set; }
		/// <summary>
		/// Gets or sets Whether to exclude inherited styles (default: false).
		/// </summary>
		public bool ExcludeInherited { get; set; }
	}
}
