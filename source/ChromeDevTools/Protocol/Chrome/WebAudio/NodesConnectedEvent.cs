using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that two AudioNodes are connected.
	/// </summary>
	[Event(ProtocolName.WebAudio.NodesConnected)]
	[SupportedBy("Chrome")]
	public class NodesConnectedEvent
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets SourceId
		/// </summary>
		public string SourceId { get; set; }
		/// <summary>
		/// Gets or sets DestinationId
		/// </summary>
		public string DestinationId { get; set; }
		/// <summary>
		/// Gets or sets SourceOutputIndex
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double SourceOutputIndex { get; set; }
		/// <summary>
		/// Gets or sets DestinationInputIndex
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DestinationInputIndex { get; set; }
	}
}
