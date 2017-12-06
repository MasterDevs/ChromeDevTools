using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[Command(ProtocolName.Emulation.SetScriptExecutionDisabled)]
	[SupportedBy("Chrome")]
	public class SetScriptExecutionDisabledCommand: ICommand<SetScriptExecutionDisabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether script execution should be disabled in the page.
		/// </summary>
		public bool Value { get; set; }
	}
}
