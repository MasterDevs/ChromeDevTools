using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Replace previous blackbox patterns with passed ones. Forces backend to skip stepping/pausing in scripts with url matching one of the patterns. VM will try to leave blackboxed script by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBlackboxPatterns)]
	[SupportedBy("Chrome")]
	public class SetBlackboxPatternsCommandResponse
	{
	}
}
