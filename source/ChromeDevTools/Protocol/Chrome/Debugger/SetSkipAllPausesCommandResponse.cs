using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetSkipAllPauses)]
	[SupportedBy("Chrome")]
	public class SetSkipAllPausesCommandResponse
	{
	}
}
