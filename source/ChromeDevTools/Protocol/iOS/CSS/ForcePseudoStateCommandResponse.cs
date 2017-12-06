using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Ensures that the given node will have specified pseudo-classes whenever its style is computed by the browser.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.ForcePseudoState)]
	[SupportedBy("iOS")]
	public class ForcePseudoStateCommandResponse
	{
	}
}
