using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>
	[Command(ProtocolName.Network.GetResponseBody)]
	[SupportedBy("iOS")]
	public class GetResponseBodyCommand: ICommand<GetResponseBodyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
