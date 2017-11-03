using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Stop violation reporting.
	/// </summary>
	[CommandResponse(ProtocolName.Log.StopViolationsReport)]
	[SupportedBy("Chrome")]
	public class StopViolationsReportCommandResponse
	{
	}
}
