using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[Command(ProtocolName.Page.SetScriptExecutionDisabled)]
	[SupportedBy("iOS")]
	public class SetScriptExecutionDisabledCommand: ICommand<SetScriptExecutionDisabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether script execution should be disabled in the page.
		/// </summary>
		public bool Value { get; set; }
	}
}
