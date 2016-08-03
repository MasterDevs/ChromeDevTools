using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	/// <summary>
	/// Disables Canvas inspection.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
