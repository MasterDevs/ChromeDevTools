using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IO
{
	/// <summary>
	/// Return UUID of Blob object specified by a remote object id.
	/// </summary>
	[Command(ProtocolName.IO.ResolveBlob)]
	[SupportedBy("Chrome")]
	public class ResolveBlobCommand: ICommand<ResolveBlobCommandResponse>
	{
		/// <summary>
		/// Gets or sets Object id of a Blob object wrapper.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
