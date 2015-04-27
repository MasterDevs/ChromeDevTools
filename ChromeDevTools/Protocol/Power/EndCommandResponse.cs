using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Stop power events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Power.End)]
	public class EndCommandResponse
	{
	}
}
