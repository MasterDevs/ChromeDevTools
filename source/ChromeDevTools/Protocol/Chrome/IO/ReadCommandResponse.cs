using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IO
{
	/// <summary>
	/// Read a chunk of the stream
	/// </summary>
	[CommandResponse(ProtocolName.IO.Read)]
	[SupportedBy("Chrome")]
	public class ReadCommandResponse
	{
		/// <summary>
		/// Gets or sets Set if the data is base64-encoded
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Base64Encoded { get; set; }
		/// <summary>
		/// Gets or sets Data that were read.
		/// </summary>
		public string Data { get; set; }
		/// <summary>
		/// Gets or sets Set if the end-of-file condition occured while reading.
		/// </summary>
		public bool Eof { get; set; }
	}
}
