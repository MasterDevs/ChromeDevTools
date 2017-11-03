using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Resumes JavaScript execution.
	/// </summary>
	[Command(ProtocolName.Debugger.Resume)]
	[SupportedBy("Chrome")]
	public class ResumeCommand: ICommand<ResumeCommandResponse>
	{
	}
}
