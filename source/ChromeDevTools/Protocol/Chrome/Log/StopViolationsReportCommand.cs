using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Stop violation reporting.
	/// </summary>
	[Command(ProtocolName.Log.StopViolationsReport)]
	[SupportedBy("Chrome")]
	public class StopViolationsReportCommand: ICommand<StopViolationsReportCommandResponse>
	{
	}
}
