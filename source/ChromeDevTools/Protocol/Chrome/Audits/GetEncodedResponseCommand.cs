using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Returns the response body and size if it were re-encoded with the specified settings. Only applies to images.
	/// </summary>
	[Command(ProtocolName.Audits.GetEncodedResponse)]
	[SupportedBy("Chrome")]
	public class GetEncodedResponseCommand: ICommand<GetEncodedResponseCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets The encoding to use.
		/// </summary>
		public string Encoding { get; set; }
		/// <summary>
		/// Gets or sets The quality of the encoding (0-1). (defaults to 1)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Quality { get; set; }
		/// <summary>
		/// Gets or sets Whether to only return the size information (defaults to false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? SizeOnly { get; set; }
	}
}
