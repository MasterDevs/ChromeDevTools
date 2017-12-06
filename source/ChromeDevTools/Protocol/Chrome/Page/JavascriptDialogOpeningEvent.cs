using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to open.
	/// </summary>
	[Event(ProtocolName.Page.JavascriptDialogOpening)]
	[SupportedBy("Chrome")]
	public class JavascriptDialogOpeningEvent
	{
		/// <summary>
		/// Gets or sets Frame url.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Message that will be displayed by the dialog.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Dialog type.
		/// </summary>
		public DialogType Type { get; set; }
		/// <summary>
		/// Gets or sets Default dialog prompt.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DefaultPrompt { get; set; }
	}
}
