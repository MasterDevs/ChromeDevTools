using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	[Obsolete]
	[Command(ProtocolName.Debugger.PauseOnAsyncCall)]
	[SupportedBy("Chrome")]
	public class PauseOnAsyncCallCommand: ICommand<PauseOnAsyncCallCommandResponse>
	{
		/// <summary>
		/// Gets or sets Debugger will pause when async call with given stack trace is started.
		/// </summary>
		public Runtime.StackTraceId ParentStackTraceId { get; set; }
	}
}
