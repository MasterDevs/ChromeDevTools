using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps into next scheduled async task if any is scheduled before next pause. Returns success when async task is actually scheduled, returns error if no task were scheduled or another scheduleStepIntoAsync was called.
	/// </summary>
	[Command(ProtocolName.Debugger.ScheduleStepIntoAsync)]
	[SupportedBy("Chrome")]
	public class ScheduleStepIntoAsyncCommand: ICommand<ScheduleStepIntoAsyncCommandResponse>
	{
	}
}
