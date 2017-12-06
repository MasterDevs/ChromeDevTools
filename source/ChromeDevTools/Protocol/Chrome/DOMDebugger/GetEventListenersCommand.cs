using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Returns event listeners of the given object.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.GetEventListeners)]
	[SupportedBy("Chrome")]
	public class GetEventListenersCommand: ICommand<GetEventListenersCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the object to return listeners for.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets The maximum depth at which Node children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Depth { get; set; }
		/// <summary>
		/// Gets or sets Whether or not iframes and shadow roots should be traversed when returning the subtree (default is false). Reports listeners for all contexts if pierce is enabled.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Pierce { get; set; }
	}
}
