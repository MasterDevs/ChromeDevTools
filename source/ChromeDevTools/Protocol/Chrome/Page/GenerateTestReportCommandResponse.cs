using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Generates a report for testing.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GenerateTestReport)]
	[SupportedBy("Chrome")]
	public class GenerateTestReportCommandResponse
	{
	}
}
