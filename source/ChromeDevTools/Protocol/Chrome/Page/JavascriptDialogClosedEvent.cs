using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been closed.
	/// </summary>
	[Event(ProtocolName.Page.JavascriptDialogClosed)]
	[SupportedBy("Chrome")]
	public class JavascriptDialogClosedEvent
	{
		/// <summary>
		/// Gets or sets Whether dialog was confirmed.
		/// </summary>
		public bool Result { get; set; }
		/// <summary>
		/// Gets or sets User input in case of prompt.
		/// </summary>
		public string UserInput { get; set; }
	}
}
