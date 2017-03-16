using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	/// <summary>
	/// Evaluates a given trace call argument or its result.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.EvaluateTraceLogCallArgument)]
	[SupportedBy("Chrome")]
	public class EvaluateTraceLogCallArgumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Object wrapper for the evaluation result.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets State of the <code>Resource</code> object.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ResourceState ResourceState { get; set; }
	}
}
