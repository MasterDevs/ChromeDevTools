using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Restarts particular call frame from the beginning.
	/// </summary>
	[Command(ProtocolName.Debugger.RestartFrame)]
	[SupportedBy("Chrome")]
	public class RestartFrameCommand: ICommand<RestartFrameCommandResponse>
	{
		/// <summary>
		/// Gets or sets Call frame identifier to evaluate on.
		/// </summary>
		public string CallFrameId { get; set; }
	}
}
