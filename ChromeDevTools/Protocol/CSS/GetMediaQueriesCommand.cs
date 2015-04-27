using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>
	[Command(ProtocolName.CSS.GetMediaQueries)]
	public class GetMediaQueriesCommand
	{
	}
}
