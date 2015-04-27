using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Ensures that the given node will have specified pseudo-classes whenever its style is computed by the browser.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.ForcePseudoState)]
	public class ForcePseudoStateCommandResponse
	{
	}
}
