using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Retrieve native memory allocations profile
	/// collected since renderer process startup.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.GetAllTimeSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetAllTimeSamplingProfileCommandResponse
	{
		/// <summary>
		/// Gets or sets Profile
		/// </summary>
		public SamplingProfile Profile { get; set; }
	}
}
