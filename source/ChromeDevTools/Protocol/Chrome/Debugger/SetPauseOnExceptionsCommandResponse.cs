using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetPauseOnExceptions)]
	[SupportedBy("Chrome")]
	public class SetPauseOnExceptionsCommandResponse
	{
	}
}
