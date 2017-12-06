using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns all class names from specified stylesheet.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.CollectClassNames)]
	[SupportedBy("Chrome")]
	public class CollectClassNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Class name list.
		/// </summary>
		public string[] ClassNames { get; set; }
	}
}
