using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Indicates the visibility of compositing borders.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetCompositingBordersVisible)]
	[SupportedBy("iOS")]
	public class GetCompositingBordersVisibleCommandResponse
	{
		/// <summary>
		/// Gets or sets If true, compositing borders are visible.
		/// </summary>
		public bool Result { get; set; }
	}
}
