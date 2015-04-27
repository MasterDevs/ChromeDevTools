using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetDocumentContent)]
	public class SetDocumentContentCommandResponse
	{
	}
}
