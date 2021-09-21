using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Called when the recording state for the service has been updated.
	/// </summary>
	[Event(ProtocolName.BackgroundService.RecordingStateChanged)]
	[SupportedBy("Chrome")]
	public class RecordingStateChangedEvent
	{
		/// <summary>
		/// Gets or sets IsRecording
		/// </summary>
		public bool IsRecording { get; set; }
		/// <summary>
		/// Gets or sets Service
		/// </summary>
		public ServiceName Service { get; set; }
	}
}
