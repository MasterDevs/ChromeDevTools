using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Specifies whether to always send extra HTTP headers with the requests from this page.
	/// </summary>
	[Command(ProtocolName.Network.SetExtraHTTPHeaders)]
	[SupportedBy("iOS")]
	public class SetExtraHTTPHeadersCommand: ICommand<SetExtraHTTPHeadersCommandResponse>
	{
		/// <summary>
		/// Gets or sets Map with extra HTTP headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
