using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Starts mirroring the tab to the sink.
	/// </summary>
	[Command(ProtocolName.Cast.StartTabMirroring)]
	[SupportedBy("Chrome")]
	public class StartTabMirroringCommand: ICommand<StartTabMirroringCommandResponse>
	{
		/// <summary>
		/// Gets or sets SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
