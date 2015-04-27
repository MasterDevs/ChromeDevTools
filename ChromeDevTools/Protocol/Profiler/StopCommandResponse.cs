using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Profiler
{
	[CommandResponse(ProtocolName.Profiler.Stop)]
	public class StopCommandResponse
	{
		/// <summary>
		/// Gets or sets Recorded profile.
		/// </summary>
		public CPUProfile Profile { get; set; }
	}
}
