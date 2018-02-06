using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// start violation reporting.
	/// </summary>
	[CommandResponse(ProtocolName.Log.StartViolationsReport)]
	[SupportedBy("Chrome")]
	public class StartViolationsReportCommandResponse
	{
	}
}
