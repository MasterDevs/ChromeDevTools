using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	[CommandResponse(ProtocolName.Canvas.StopCapturing)]
	[SupportedBy("Chrome")]
	public class StopCapturingCommandResponse
	{
	}
}
