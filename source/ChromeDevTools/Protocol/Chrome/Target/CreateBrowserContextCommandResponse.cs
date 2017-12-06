using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than one.
	/// </summary>
	[CommandResponse(ProtocolName.Target.CreateBrowserContext)]
	[SupportedBy("Chrome")]
	public class CreateBrowserContextCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the context created.
		/// </summary>
		public string BrowserContextId { get; set; }
	}
}
