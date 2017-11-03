using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Evaluates expression on a given call frame.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.EvaluateOnCallFrame)]
	[SupportedBy("iOS")]
	public class EvaluateOnCallFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Object wrapper for the evaluation result.
		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets True if the result was thrown during the evaluation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? WasThrown { get; set; }
		/// <summary>
		/// Gets or sets If the result was saved, this is the $n index that can be used to access the value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SavedResultIndex { get; set; }
	}
}
