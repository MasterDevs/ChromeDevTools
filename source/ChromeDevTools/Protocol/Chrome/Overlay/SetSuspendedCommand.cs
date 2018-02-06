using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[Command(ProtocolName.Overlay.SetSuspended)]
	[SupportedBy("Chrome")]
	public class SetSuspendedCommand: ICommand<SetSuspendedCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether overlay should be suspended and not consume any resources until resumed.
		/// </summary>
		public bool Suspended { get; set; }
	}
}
