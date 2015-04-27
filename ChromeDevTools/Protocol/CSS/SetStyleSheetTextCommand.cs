using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>
	[Command(ProtocolName.CSS.SetStyleSheetText)]
	public class SetStyleSheetTextCommand
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Text
		/// </summary>
		public string Text { get; set; }
	}
}
