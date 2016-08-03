using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Rendering
{
	/// <summary>
	/// Requests that backend enables continuous painting
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetContinuousPaintingEnabled)]
	[SupportedBy("Chrome")]
	public class SetContinuousPaintingEnabledCommandResponse
	{
	}
}
