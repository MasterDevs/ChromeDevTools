using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Tries to update the web lifecycle state of the page.
	/// It will transition the page to the given state according to:
	/// https://github.com/WICG/web-lifecycle/
	/// </summary>
	[Command(ProtocolName.Page.SetWebLifecycleState)]
	[SupportedBy("Chrome")]
	public class SetWebLifecycleStateCommand: ICommand<SetWebLifecycleStateCommandResponse>
	{
		/// <summary>
		/// Gets or sets Target lifecycle state
		/// </summary>
		public string State { get; set; }
	}
}
