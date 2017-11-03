using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Controls whether to automatically attach to new targets which are considered to be related to this one. When turned on, attaches to all existing related targets as well. When turned off, automatically detaches from all currently attached targets.
	/// </summary>
	[Command(ProtocolName.Target.SetAutoAttach)]
	[SupportedBy("Chrome")]
	public class SetAutoAttachCommand: ICommand<SetAutoAttachCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to auto-attach to related targets.
		/// </summary>
		public bool AutoAttach { get; set; }
		/// <summary>
		/// Gets or sets Whether to pause new targets when attaching to them. Use <code>Runtime.runIfWaitingForDebugger</code> to run paused targets.
		/// </summary>
		public bool WaitForDebuggerOnStart { get; set; }
	}
}
