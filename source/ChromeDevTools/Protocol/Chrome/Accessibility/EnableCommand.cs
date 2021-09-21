using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Enables the accessibility domain which causes `AXNodeId`s to remain consistent between method calls.
	/// This turns on accessibility for the page, which can impact performance until accessibility is disabled.
	/// </summary>
	[Command(ProtocolName.Accessibility.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
