using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[Command(ProtocolName.Emulation.SetScriptExecutionDisabled)]
	public class SetScriptExecutionDisabledCommand
	{
		/// <summary>
		/// Gets or sets Whether script execution should be disabled in the page.
		/// </summary>
		public bool Value { get; set; }
	}
}
