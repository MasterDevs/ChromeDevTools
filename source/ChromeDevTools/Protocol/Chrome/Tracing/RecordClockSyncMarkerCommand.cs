using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Record a clock sync marker in the trace.
	/// </summary>
	[Command(ProtocolName.Tracing.RecordClockSyncMarker)]
	[SupportedBy("Chrome")]
	public class RecordClockSyncMarkerCommand: ICommand<RecordClockSyncMarkerCommandResponse>
	{
		/// <summary>
		/// Gets or sets The ID of this clock sync marker
		/// </summary>
		public string SyncId { get; set; }
	}
}
