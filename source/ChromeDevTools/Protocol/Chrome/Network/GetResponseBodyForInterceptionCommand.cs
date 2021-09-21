using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns content served for the given currently intercepted request.
	/// </summary>
	[Command(ProtocolName.Network.GetResponseBodyForInterception)]
	[SupportedBy("Chrome")]
	public class GetResponseBodyForInterceptionCommand: ICommand<GetResponseBodyForInterceptionCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier for the intercepted request to get body for.
		/// </summary>
		public string InterceptionId { get; set; }
	}
}
