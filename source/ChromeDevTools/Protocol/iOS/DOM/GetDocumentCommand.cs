using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>
	[Command(ProtocolName.DOM.GetDocument)]
	[SupportedBy("iOS")]
	public class GetDocumentCommand: ICommand<GetDocumentCommandResponse>
	{
	}
}
