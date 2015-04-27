using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend enables continuous painting
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetContinuousPaintingEnabled)]
	public class SetContinuousPaintingEnabledCommandResponse
	{
	}
}
