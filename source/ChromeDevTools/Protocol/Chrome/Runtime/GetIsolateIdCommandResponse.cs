using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns the isolate id.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetIsolateId)]
	[SupportedBy("Chrome")]
	public class GetIsolateIdCommandResponse
	{
		/// <summary>
		/// Gets or sets The isolate id.
		/// </summary>
		public string Id { get; set; }
	}
}
