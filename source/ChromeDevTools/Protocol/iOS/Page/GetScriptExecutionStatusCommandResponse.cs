using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Determines if scripts can be executed in the page.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetScriptExecutionStatus)]
	[SupportedBy("iOS")]
	public class GetScriptExecutionStatusCommandResponse
	{
		/// <summary>
		/// Gets or sets Script execution status: "allowed" if scripts can be executed, "disabled" if script execution has been disabled through page settings, "forbidden" if script execution for the given page is not possible for other reasons.
		/// </summary>
		public string Result { get; set; }
	}
}
