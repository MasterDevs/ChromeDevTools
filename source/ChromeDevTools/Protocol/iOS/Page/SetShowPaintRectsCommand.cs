using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[Command(ProtocolName.Page.SetShowPaintRects)]
	[SupportedBy("iOS")]
	public class SetShowPaintRectsCommand: ICommand<SetShowPaintRectsCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing paint rectangles
		/// </summary>
		public bool Result { get; set; }
	}
}
