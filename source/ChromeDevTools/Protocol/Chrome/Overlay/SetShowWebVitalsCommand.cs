using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Request that backend shows an overlay with web vital metrics.
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowWebVitals)]
	[SupportedBy("Chrome")]
	public class SetShowWebVitalsCommand: ICommand<SetShowWebVitalsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Show
		/// </summary>
		public bool Show { get; set; }
	}
}
