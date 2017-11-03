using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns all class names from specified stylesheet.
	/// </summary>
	[Command(ProtocolName.CSS.CollectClassNames)]
	[SupportedBy("Chrome")]
	public class CollectClassNamesCommand: ICommand<CollectClassNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
