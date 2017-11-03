using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceTree)]
	[SupportedBy("iOS")]
	public class GetResourceTreeCommand: ICommand<GetResourceTreeCommandResponse>
	{
	}
}
