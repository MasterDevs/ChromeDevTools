using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns all supported CSS property names.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetSupportedCSSProperties)]
	[SupportedBy("iOS")]
	public class GetSupportedCSSPropertiesCommandResponse
	{
		/// <summary>
		/// Gets or sets Supported property metainfo.
		/// </summary>
		public CSSPropertyInfo[] CssProperties { get; set; }
	}
}
