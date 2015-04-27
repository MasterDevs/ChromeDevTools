using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
	/// </summary>
	[CommandResponse(ProtocolName.Page.HandleJavaScriptDialog)]
	public class HandleJavaScriptDialogCommandResponse
	{
	}
}
