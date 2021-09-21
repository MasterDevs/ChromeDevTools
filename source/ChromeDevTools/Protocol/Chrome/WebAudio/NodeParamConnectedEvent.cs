using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that an AudioNode is connected to an AudioParam.
	/// </summary>
	[Event(ProtocolName.WebAudio.NodeParamConnected)]
	[SupportedBy("Chrome")]
	public class NodeParamConnectedEvent
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
	}
}
