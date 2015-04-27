using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetSkipAllPauses)]
	public class SetSkipAllPausesCommandResponse
	{
	}
}
