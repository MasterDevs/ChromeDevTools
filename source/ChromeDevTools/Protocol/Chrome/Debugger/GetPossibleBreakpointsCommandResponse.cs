using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns possible locations for breakpoint. scriptId in start and end range locations should be the same.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetPossibleBreakpoints)]
	[SupportedBy("Chrome")]
	public class GetPossibleBreakpointsCommandResponse
	{
		/// <summary>
		/// Gets or sets List of the possible breakpoint locations.
		/// </summary>
		public BreakLocation[] Locations { get; set; }
	}
}
