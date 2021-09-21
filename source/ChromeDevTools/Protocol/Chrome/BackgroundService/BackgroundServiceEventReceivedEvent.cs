using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Called with all existing backgroundServiceEvents when enabled, and all new
	/// events afterwards if enabled and recording.
	/// </summary>
	[Event(ProtocolName.BackgroundService.BackgroundServiceEventReceived)]
	[SupportedBy("Chrome")]
	public class BackgroundServiceEventReceivedEvent
	{
		/// <summary>
		/// Gets or sets BackgroundServiceEvent
		/// </summary>
		public BackgroundServiceEvent BackgroundServiceEvent { get; set; }
	}
}
