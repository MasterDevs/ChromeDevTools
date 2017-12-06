using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	/// <summary>
	/// Tells whether browser supports workers inspection.
	/// </summary>
	[CommandResponse(ProtocolName.Worker.CanInspectWorkers)]
	[SupportedBy("iOS")]
	public class CanInspectWorkersCommandResponse
	{
		/// <summary>
		/// Gets or sets True if browser has workers support.
		/// </summary>
		public bool Result { get; set; }
	}
}
