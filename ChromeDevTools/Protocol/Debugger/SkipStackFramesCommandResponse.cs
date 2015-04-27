using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Makes backend skip steps in the sources with names matching given pattern. VM will try leave blacklisted scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SkipStackFrames)]
	public class SkipStackFramesCommandResponse
	{
	}
}
