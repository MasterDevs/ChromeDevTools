using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Obtain list of rules that became used since last call to this method (or since start of coverage instrumentation)
	/// </summary>
	[CommandResponse(ProtocolName.CSS.TakeCoverageDelta)]
	[SupportedBy("Chrome")]
	public class TakeCoverageDeltaCommandResponse
	{
		/// <summary>
		/// Gets or sets Coverage
		/// </summary>
		public RuleUsage[] Coverage { get; set; }
	}
}
