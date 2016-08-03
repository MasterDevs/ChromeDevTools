using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Makes backend skip steps in the sources with names matching given pattern. VM will try leave blacklisted scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SkipStackFrames)]
	[SupportedBy("Chrome")]
	public class SkipStackFramesCommandResponse
	{
	}
}
