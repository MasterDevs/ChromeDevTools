using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns possible locations for breakpoint. scriptId in start and end range locations should be the same.
	/// </summary>
	[Command(ProtocolName.Debugger.GetPossibleBreakpoints)]
	[SupportedBy("Chrome")]
	public class GetPossibleBreakpointsCommand
	{
		/// <summary>
		/// Gets or sets Start of range to search possible breakpoint locations in.
		/// </summary>
		public Location Start { get; set; }
		/// <summary>
		/// Gets or sets End of range to search possible breakpoint locations in (excluding). When not specifed, end of scripts is used as end of range.
		/// </summary>
		public Location End { get; set; }
		/// <summary>
		/// Gets or sets Only consider locations which are in the same (non-nested) function as start.
		/// </summary>
		public bool RestrictToFunction { get; set; }
	}
}
