using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns stylesheet data for the specified <code>styleSheetId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetStyleSheet)]
	[SupportedBy("iOS")]
	public class GetStyleSheetCommand: ICommand<GetStyleSheetCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
