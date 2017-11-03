using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Disables the CSS agent for the given page.
	/// </summary>
	[Command(ProtocolName.CSS.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
