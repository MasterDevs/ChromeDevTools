using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Polls the next batch of computed style updates.
	/// </summary>
	[Command(ProtocolName.CSS.TakeComputedStyleUpdates)]
	[SupportedBy("Chrome")]
	public class TakeComputedStyleUpdatesCommand: ICommand<TakeComputedStyleUpdatesCommandResponse>
	{
	}
}
