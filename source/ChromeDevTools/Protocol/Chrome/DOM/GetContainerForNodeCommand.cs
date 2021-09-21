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
	[Command(ProtocolName.DOM.GetContainerForNode)]
	[SupportedBy("Chrome")]
	public class GetContainerForNodeCommand: ICommand<GetContainerForNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets ContainerName
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ContainerName { get; set; }
	}
}
