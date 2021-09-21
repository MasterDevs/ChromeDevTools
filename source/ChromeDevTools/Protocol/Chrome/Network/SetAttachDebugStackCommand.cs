using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Specifies whether to attach a page script stack id in requests
	/// </summary>
	[Command(ProtocolName.Network.SetAttachDebugStack)]
	[SupportedBy("Chrome")]
	public class SetAttachDebugStackCommand: ICommand<SetAttachDebugStackCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to attach a page script stack for debugging purpose.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
