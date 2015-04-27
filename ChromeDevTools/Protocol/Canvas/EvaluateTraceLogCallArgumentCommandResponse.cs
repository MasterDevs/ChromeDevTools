using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Evaluates a given trace call argument or its result.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.EvaluateTraceLogCallArgument)]
	public class EvaluateTraceLogCallArgumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Object wrapper for the evaluation result.
		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets State of the <code>Resource</code> object.
		/// </summary>
		public ResourceState ResourceState { get; set; }
	}
}
