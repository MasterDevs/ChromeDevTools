using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the current textual content and the URL for a stylesheet.
	/// </summary>
	[Command(ProtocolName.CSS.GetStyleSheetText)]
	public class GetStyleSheetTextCommand
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
