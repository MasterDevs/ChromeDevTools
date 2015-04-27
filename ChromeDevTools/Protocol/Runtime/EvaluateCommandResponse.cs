using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Evaluates expression on global object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Evaluate)]
	public class EvaluateCommandResponse
	{
		/// <summary>
		/// Gets or sets Evaluation result.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets True if the result was thrown during the evaluation.
		/// </summary>
		public bool WasThrown { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		public Debugger.ExceptionDetails ExceptionDetails { get; set; }
	}
}
