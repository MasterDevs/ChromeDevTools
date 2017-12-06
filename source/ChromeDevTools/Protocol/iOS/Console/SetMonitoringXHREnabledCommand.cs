using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Toggles monitoring of XMLHttpRequest. If <code>true</code>, console will receive messages upon each XHR issued.
	/// </summary>
	[Command(ProtocolName.Console.SetMonitoringXHREnabled)]
	[SupportedBy("iOS")]
	public class SetMonitoringXHREnabledCommand: ICommand<SetMonitoringXHREnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Monitoring enabled state.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
