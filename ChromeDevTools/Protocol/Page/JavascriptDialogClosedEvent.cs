using ChromeDevTools;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been closed.
	/// </summary>
	[Event(ProtocolName.Page.JavascriptDialogClosed)]
	public class JavascriptDialogClosedEvent
	{
	}
}
