using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Changes value of variable in a callframe. Object-based scopes are not supported and must be mutated manually.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetVariableValue)]
	[SupportedBy("Chrome")]
	public class SetVariableValueCommandResponse
	{
	}
}
