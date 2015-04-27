using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>
	[Command(ProtocolName.DOM.GetDocument)]
	public class GetDocumentCommand
	{
	}
}
