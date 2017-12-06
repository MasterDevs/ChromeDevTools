using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Toggles ignoring of service worker for each request.
	/// </summary>
	[Command(ProtocolName.Network.SetBypassServiceWorker)]
	[SupportedBy("Chrome")]
	public class SetBypassServiceWorkerCommand: ICommand<SetBypassServiceWorkerCommandResponse>
	{
		/// <summary>
		/// Gets or sets Bypass service worker and load from network.
		/// </summary>
		public bool Bypass { get; set; }
	}
}
