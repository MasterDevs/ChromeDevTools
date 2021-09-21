using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to
	/// open.
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
		/// Gets or sets True iff browser is capable showing or acting on the given dialog. When browser has no
		/// dialog handler for given target, calling alert while Page domain is engaged will stall
		/// the page execution. Execution can be resumed via calling Page.handleJavaScriptDialog.
		/// </summary>
		public bool HasBrowserHandler { get; set; }
		/// <summary>
		/// Gets or sets Default dialog prompt.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DefaultPrompt { get; set; }
	}
}
