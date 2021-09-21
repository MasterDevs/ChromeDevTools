using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns present frame tree structure.
	/// </summary>
	[Command(ProtocolName.Page.GetFrameTree)]
	[SupportedBy("Chrome")]
	public class GetFrameTreeCommand: ICommand<GetFrameTreeCommandResponse>
	{
	}
}
