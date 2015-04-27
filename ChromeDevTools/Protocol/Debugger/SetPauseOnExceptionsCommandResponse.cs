using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetPauseOnExceptions)]
	public class SetPauseOnExceptionsCommandResponse
	{
	}
}
