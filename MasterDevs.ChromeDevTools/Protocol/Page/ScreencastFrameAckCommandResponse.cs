using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Acknowledges that a screencast frame has been received by the frontend.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ScreencastFrameAck)]
	public class ScreencastFrameAckCommandResponse
	{
	}
}
