using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>
	[Command(ProtocolName.Debugger.ContinueToLocation)]
	[SupportedBy("Chrome")]
	public class ContinueToLocationCommand: ICommand<ContinueToLocationCommandResponse>
	{
		/// <summary>
		/// Gets or sets Location to continue to.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets TargetCallFrames
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetCallFrames { get; set; }
	}
}
