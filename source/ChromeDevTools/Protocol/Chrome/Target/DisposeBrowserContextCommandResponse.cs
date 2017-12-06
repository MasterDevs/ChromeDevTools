using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Deletes a BrowserContext, will fail of any open page uses it.
	/// </summary>
	[CommandResponse(ProtocolName.Target.DisposeBrowserContext)]
	[SupportedBy("Chrome")]
	public class DisposeBrowserContextCommandResponse
	{
		/// <summary>
		/// Gets or sets Success
		/// </summary>
		public bool Success { get; set; }
	}
}
