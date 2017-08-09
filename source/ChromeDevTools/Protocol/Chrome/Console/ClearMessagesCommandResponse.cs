using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Does nothing.
	/// </summary>
	[CommandResponse(ProtocolName.Console.ClearMessages)]
	[SupportedBy("Chrome")]
	public class ClearMessagesCommandResponse
	{
	}
}
