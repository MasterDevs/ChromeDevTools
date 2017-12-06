using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Parses JavaScript source code for errors.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Parse)]
	[SupportedBy("iOS")]
	public class ParseCommandResponse
	{
		/// <summary>
		/// Gets or sets Parse result.
		/// </summary>
		public string Result { get; set; }
		/// <summary>
		/// Gets or sets Parse error message.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Range in the source where the error occurred.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ErrorRange Range { get; set; }
	}
}
