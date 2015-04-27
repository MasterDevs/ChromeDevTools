using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Evaluates a given trace call argument or its result.
	/// </summary>
	[Command(ProtocolName.Canvas.EvaluateTraceLogCallArgument)]
	public class EvaluateTraceLogCallArgumentCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets Index of the call to evaluate on (zero based).
		/// </summary>
		public long CallIndex { get; set; }
		/// <summary>
		/// Gets or sets Index of the argument to evaluate (zero based). Provide <code>-1</code> to evaluate call result.
		/// </summary>
		public long ArgumentIndex { get; set; }
		/// <summary>
		/// Gets or sets String object group name to put result into (allows rapid releasing resulting object handles using <code>Runtime.releaseObjectGroup</code>).
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
