using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>
	[Command(ProtocolName.Network.GetResponseBody)]
	[SupportedBy("Chrome")]
	public class GetResponseBodyCommand: ICommand<GetResponseBodyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
