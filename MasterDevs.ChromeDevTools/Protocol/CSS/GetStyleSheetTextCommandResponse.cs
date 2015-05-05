using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the current textual content and the URL for a stylesheet.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetStyleSheetText)]
	public class GetStyleSheetTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The stylesheet text.
		/// </summary>
		public string Text { get; set; }
	}
}
