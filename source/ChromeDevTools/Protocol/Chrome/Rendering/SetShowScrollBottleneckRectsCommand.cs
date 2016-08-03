using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Rendering
{
	/// <summary>
	/// Requests that backend shows scroll bottleneck rects
	/// </summary>
	[Command(ProtocolName.Rendering.SetShowScrollBottleneckRects)]
	[SupportedBy("Chrome")]
	public class SetShowScrollBottleneckRectsCommand
	{
		/// <summary>
		/// Gets or sets True for showing scroll bottleneck rects
		/// </summary>
		public bool Show { get; set; }
	}
}
