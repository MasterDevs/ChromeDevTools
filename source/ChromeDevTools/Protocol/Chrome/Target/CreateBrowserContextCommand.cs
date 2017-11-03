using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than one.
	/// </summary>
	[Command(ProtocolName.Target.CreateBrowserContext)]
	[SupportedBy("Chrome")]
	public class CreateBrowserContextCommand: ICommand<CreateBrowserContextCommandResponse>
	{
	}
}
