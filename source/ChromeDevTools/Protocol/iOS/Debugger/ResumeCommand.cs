using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Resumes JavaScript execution.
	/// </summary>
	[Command(ProtocolName.Debugger.Resume)]
	[SupportedBy("iOS")]
	public class ResumeCommand: ICommand<ResumeCommandResponse>
	{
	}
}
