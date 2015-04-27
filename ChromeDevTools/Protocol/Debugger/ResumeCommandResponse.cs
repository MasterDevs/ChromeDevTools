using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Resumes JavaScript execution.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Resume)]
	public class ResumeCommandResponse
	{
	}
}
