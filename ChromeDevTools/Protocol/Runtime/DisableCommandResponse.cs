using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Disables reporting of execution contexts creation.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Disable)]
	public class DisableCommandResponse
	{
	}
}
