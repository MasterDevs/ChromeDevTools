using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Determines if scripts can be executed in the page.
	/// </summary>
	[Command(ProtocolName.Page.GetScriptExecutionStatus)]
	[SupportedBy("iOS")]
	public class GetScriptExecutionStatusCommand: ICommand<GetScriptExecutionStatusCommandResponse>
	{
	}
}
