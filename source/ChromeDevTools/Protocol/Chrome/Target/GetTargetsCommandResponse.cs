using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Retrieves a list of available targets.
	/// </summary>
	[CommandResponse(ProtocolName.Target.GetTargets)]
	[SupportedBy("Chrome")]
	public class GetTargetsCommandResponse
	{
		/// <summary>
		/// Gets or sets The list of targets.
		/// </summary>
		public TargetInfo[] TargetInfos { get; set; }
	}
}
