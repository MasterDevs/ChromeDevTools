using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to open.
	/// </summary>
	[Event(ProtocolName.Page.JavascriptDialogOpening)]
	[SupportedBy("iOS")]
	public class JavascriptDialogOpeningEvent
	{
		/// <summary>
		/// Gets or sets Message that will be displayed by the dialog.
		/// </summary>
		public string Message { get; set; }
	}
}
