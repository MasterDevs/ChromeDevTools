using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Enables event updates for the service.
	/// </summary>
	[Command(ProtocolName.BackgroundService.StartObserving)]
	[SupportedBy("Chrome")]
	public class StartObservingCommand: ICommand<StartObservingCommandResponse>
	{
		/// <summary>
		/// Gets or sets Service
		/// </summary>
		public string Service { get; set; }
	}
}
