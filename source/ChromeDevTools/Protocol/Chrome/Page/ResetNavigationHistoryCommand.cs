using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Resets navigation history for the current page.
	/// </summary>
	[Command(ProtocolName.Page.ResetNavigationHistory)]
	[SupportedBy("Chrome")]
	public class ResetNavigationHistoryCommand: ICommand<ResetNavigationHistoryCommandResponse>
	{
	}
}
