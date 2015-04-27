using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Requests that scroll offsets and page scale factor are reset to initial values.
	/// </summary>
	[Command(ProtocolName.Emulation.ResetScrollAndPageScaleFactor)]
	public class ResetScrollAndPageScaleFactorCommand
	{
	}
}
