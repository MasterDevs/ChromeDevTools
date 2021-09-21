using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows hit-test borders on layers
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowHitTestBorders)]
	[SupportedBy("Chrome")]
	public class SetShowHitTestBordersCommand: ICommand<SetShowHitTestBordersCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing hit-test borders
		/// </summary>
		public bool Show { get; set; }
	}
}
