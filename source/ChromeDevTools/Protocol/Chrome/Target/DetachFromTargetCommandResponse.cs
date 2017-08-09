using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Detaches from the target with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Target.DetachFromTarget)]
	[SupportedBy("Chrome")]
	public class DetachFromTargetCommandResponse
	{
	}
}
