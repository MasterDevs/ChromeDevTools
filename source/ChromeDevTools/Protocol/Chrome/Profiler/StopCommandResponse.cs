using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	[CommandResponse(ProtocolName.Profiler.Stop)]
	[SupportedBy("Chrome")]
	public class StopCommandResponse
	{
		/// <summary>
		/// Gets or sets Recorded profile.
		/// </summary>
		public Profile Profile { get; set; }
	}
}
