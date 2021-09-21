using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets if stack traces should be captured for Nodes. See `Node.getNodeStackTraces`. Default is disabled.
	/// </summary>
	[Command(ProtocolName.DOM.SetNodeStackTracesEnabled)]
	[SupportedBy("Chrome")]
	public class SetNodeStackTracesEnabledCommand: ICommand<SetNodeStackTracesEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Enable or disable.
		/// </summary>
		public bool Enable { get; set; }
	}
}
