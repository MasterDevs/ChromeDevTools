using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Creates an isolated world for the given frame.
	/// </summary>
	[CommandResponse(ProtocolName.Page.CreateIsolatedWorld)]
	[SupportedBy("Chrome")]
	public class CreateIsolatedWorldCommandResponse
	{
	}
}
