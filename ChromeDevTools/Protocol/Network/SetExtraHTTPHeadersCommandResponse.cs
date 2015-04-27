using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Specifies whether to always send extra HTTP headers with the requests from this page.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetExtraHTTPHeaders)]
	public class SetExtraHTTPHeadersCommandResponse
	{
	}
}
