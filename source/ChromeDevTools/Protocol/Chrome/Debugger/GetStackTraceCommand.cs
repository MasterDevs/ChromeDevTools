using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns stack trace with given `stackTraceId`.
	/// </summary>
	[Command(ProtocolName.Debugger.GetStackTrace)]
	[SupportedBy("Chrome")]
	public class GetStackTraceCommand: ICommand<GetStackTraceCommandResponse>
	{
		/// <summary>
		/// Gets or sets StackTraceId
		/// </summary>
		public Runtime.StackTraceId StackTraceId { get; set; }
	}
}
