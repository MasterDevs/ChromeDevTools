using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the container of the given node based on container query conditions.
	/// If containerName is given, it will find the nearest container with a matching name;
	/// otherwise it will find the nearest container regardless of its container name.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetContainerForNode)]
	[SupportedBy("Chrome")]
	public class GetContainerForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets The container node for the given node, or null if not found.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
	}
}
