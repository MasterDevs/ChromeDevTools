using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows debug borders on layers
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetShowDebugBorders)]
	public class SetShowDebugBordersCommandResponse
	{
	}
}
