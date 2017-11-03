using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Returns information about a target.
	/// </summary>
	[CommandResponse(ProtocolName.Target.GetTargetInfo)]
	[SupportedBy("Chrome")]
	public class GetTargetInfoCommandResponse
	{
		/// <summary>
		/// Gets or sets TargetInfo
		/// </summary>
		public TargetInfo TargetInfo { get; set; }
	}
}
