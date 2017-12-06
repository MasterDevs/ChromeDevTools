using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns node id at given location.
	/// </summary>
	[Command(ProtocolName.DOM.GetNodeForLocation)]
	[SupportedBy("Chrome")]
	public class GetNodeForLocationCommand: ICommand<GetNodeForLocationCommandResponse>
	{
		/// <summary>
		/// Gets or sets X coordinate.
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate.
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets False to skip to the nearest non-UA shadow root ancestor (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeUserAgentShadowDOM { get; set; }
	}
}
