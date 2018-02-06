using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns the current textual content and the URL for a stylesheet.
	/// </summary>
	[Command(ProtocolName.CSS.GetStyleSheetText)]
	[SupportedBy("iOS")]
	public class GetStyleSheetTextCommand: ICommand<GetStyleSheetTextCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
