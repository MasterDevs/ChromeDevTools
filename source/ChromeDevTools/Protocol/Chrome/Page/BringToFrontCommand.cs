using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Brings page to front (activates tab).
	/// </summary>
	[Command(ProtocolName.Page.BringToFront)]
	[SupportedBy("Chrome")]
	public class BringToFrontCommand: ICommand<BringToFrontCommandResponse>
	{
	}
}
