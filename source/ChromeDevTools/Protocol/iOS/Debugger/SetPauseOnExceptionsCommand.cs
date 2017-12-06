using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
	/// </summary>
	[Command(ProtocolName.Debugger.SetPauseOnExceptions)]
	[SupportedBy("iOS")]
	public class SetPauseOnExceptionsCommand: ICommand<SetPauseOnExceptionsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Pause on exceptions mode.
		/// </summary>
		public string State { get; set; }
	}
}
