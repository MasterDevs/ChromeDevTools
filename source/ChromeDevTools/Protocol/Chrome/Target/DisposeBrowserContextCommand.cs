using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Deletes a BrowserContext, will fail of any open page uses it.
	/// </summary>
	[Command(ProtocolName.Target.DisposeBrowserContext)]
	[SupportedBy("Chrome")]
	public class DisposeBrowserContextCommand: ICommand<DisposeBrowserContextCommandResponse>
	{
		/// <summary>
		/// Gets or sets BrowserContextId
		/// </summary>
		public string BrowserContextId { get; set; }
	}
}
