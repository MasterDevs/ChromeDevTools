using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Creates an isolated world for the given frame.
	/// </summary>
	[CommandResponse(ProtocolName.Page.CreateIsolatedWorld)]
	[SupportedBy("Chrome")]
	public class CreateIsolatedWorldCommandResponse
	{
		/// <summary>
		/// Gets or sets Execution context of the isolated world.
		/// </summary>
		public long ExecutionContextId { get; set; }
	}
}
