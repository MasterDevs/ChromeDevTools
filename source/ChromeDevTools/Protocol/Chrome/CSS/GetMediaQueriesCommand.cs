using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>
	[Command(ProtocolName.CSS.GetMediaQueries)]
	[SupportedBy("Chrome")]
	public class GetMediaQueriesCommand: ICommand<GetMediaQueriesCommandResponse>
	{
	}
}
