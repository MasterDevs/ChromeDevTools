using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been closed.
	/// </summary>
	[Event(ProtocolName.Page.JavascriptDialogClosed)]
	[SupportedBy("iOS")]
	public class JavascriptDialogClosedEvent
	{
	}
}
