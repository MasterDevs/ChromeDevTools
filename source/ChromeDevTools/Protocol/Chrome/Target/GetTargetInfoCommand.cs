using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Returns information about a target.
	/// </summary>
	[Command(ProtocolName.Target.GetTargetInfo)]
	[SupportedBy("Chrome")]
	public class GetTargetInfoCommand: ICommand<GetTargetInfoCommandResponse>
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
