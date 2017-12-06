using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IO
{
	/// <summary>
	/// Return UUID of Blob object specified by a remote object id.
	/// </summary>
	[CommandResponse(ProtocolName.IO.ResolveBlob)]
	[SupportedBy("Chrome")]
	public class ResolveBlobCommandResponse
	{
		/// <summary>
		/// Gets or sets UUID of the specified Blob.
		/// </summary>
		public string Uuid { get; set; }
	}
}
