using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows debug borders on layers
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowDebugBorders)]
	[SupportedBy("Chrome")]
	public class SetShowDebugBordersCommand: ICommand<SetShowDebugBordersCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing debug borders
		/// </summary>
		public bool Show { get; set; }
	}
}
