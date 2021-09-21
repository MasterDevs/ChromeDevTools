using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Sets time domain to use for collecting and reporting duration metrics.
	/// Note that this must be called before enabling metrics collection. Calling
	/// This method while metrics collection is enabled returns an error.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Performance.SetTimeDomain)]
	[SupportedBy("Chrome")]
	public class SetTimeDomainCommandResponse
	{
	}
}
