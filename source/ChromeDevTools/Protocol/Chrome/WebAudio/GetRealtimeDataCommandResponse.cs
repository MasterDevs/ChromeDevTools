using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Fetch the realtime data from the registered contexts.
	/// </summary>
	[CommandResponse(ProtocolName.WebAudio.GetRealtimeData)]
	[SupportedBy("Chrome")]
	public class GetRealtimeDataCommandResponse
	{
		/// <summary>
		/// Gets or sets RealtimeData
		/// </summary>
		public ContextRealtimeData RealtimeData { get; set; }
	}
}
