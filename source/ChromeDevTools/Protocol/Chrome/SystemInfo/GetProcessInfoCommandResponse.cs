using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about all running processes.
	/// </summary>
	[CommandResponse(ProtocolName.SystemInfo.GetProcessInfo)]
	[SupportedBy("Chrome")]
	public class GetProcessInfoCommandResponse
	{
		/// <summary>
		/// Gets or sets An array of process info blocks.
		/// </summary>
		public ProcessInfo[] ProcessInfo { get; set; }
	}
}
