using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Does nothing.
	/// </summary>
	[Command(ProtocolName.Console.ClearMessages)]
	[SupportedBy("Chrome")]
	public class ClearMessagesCommand: ICommand<ClearMessagesCommandResponse>
	{
	}
}
