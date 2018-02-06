using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetDocumentContent)]
	[SupportedBy("iOS")]
	public class SetDocumentContentCommandResponse
	{
	}
}
