using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Forces compilation cache to be generated for every subresource script.
	/// See also: `Page.produceCompilationCache`.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetProduceCompilationCache)]
	[SupportedBy("Chrome")]
	public class SetProduceCompilationCacheCommandResponse
	{
	}
}
