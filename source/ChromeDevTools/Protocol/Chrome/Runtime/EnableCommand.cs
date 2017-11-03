using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Enables reporting of execution contexts creation by means of <code>executionContextCreated</code> event. When the reporting gets enabled the event will be sent immediately for each existing execution context.
	/// </summary>
	[Command(ProtocolName.Runtime.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
