using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns post data sent with the request. Returns an error when no data was sent with the request.
	/// </summary>
	[Command(ProtocolName.Network.GetRequestPostData)]
	[SupportedBy("Chrome")]
	public class GetRequestPostDataCommand: ICommand<GetRequestPostDataCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
