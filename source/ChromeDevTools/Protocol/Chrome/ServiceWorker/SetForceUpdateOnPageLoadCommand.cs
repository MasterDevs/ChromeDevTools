using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.SetForceUpdateOnPageLoad)]
	[SupportedBy("Chrome")]
	public class SetForceUpdateOnPageLoadCommand: ICommand<SetForceUpdateOnPageLoadCommandResponse>
	{
		/// <summary>
		/// Gets or sets ForceUpdateOnPageLoad
		/// </summary>
		public bool ForceUpdateOnPageLoad { get; set; }
	}
}
