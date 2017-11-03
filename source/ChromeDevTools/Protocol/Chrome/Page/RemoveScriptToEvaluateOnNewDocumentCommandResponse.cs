using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Removes given script from the list.
	/// </summary>
	[CommandResponse(ProtocolName.Page.RemoveScriptToEvaluateOnNewDocument)]
	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnNewDocumentCommandResponse
	{
	}
}
