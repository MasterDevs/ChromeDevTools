using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows scroll bottleneck rects
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowScrollBottleneckRects)]
	[SupportedBy("Chrome")]
	public class SetShowScrollBottleneckRectsCommand: ICommand<SetShowScrollBottleneckRectsCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing scroll bottleneck rects
		/// </summary>
		public bool Show { get; set; }
	}
}
