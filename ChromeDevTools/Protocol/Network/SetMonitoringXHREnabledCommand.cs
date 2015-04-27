using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Toggles monitoring of XMLHttpRequest. If <code>true</code>, console will receive messages upon each XHR issued.
	/// </summary>
	[Command(ProtocolName.Network.SetMonitoringXHREnabled)]
	public class SetMonitoringXHREnabledCommand
	{
		/// <summary>
		/// Gets or sets Monitoring enabled state.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
