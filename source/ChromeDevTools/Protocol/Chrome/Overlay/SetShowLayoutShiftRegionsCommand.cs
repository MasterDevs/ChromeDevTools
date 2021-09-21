using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows layout shift regions
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowLayoutShiftRegions)]
	[SupportedBy("Chrome")]
	public class SetShowLayoutShiftRegionsCommand: ICommand<SetShowLayoutShiftRegionsCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing layout shift regions
		/// </summary>
		public bool Result { get; set; }
	}
}
