using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
	/// </summary>
	[Command(ProtocolName.Network.SetAcceptedEncodings)]
	[SupportedBy("Chrome")]
	public class SetAcceptedEncodingsCommand: ICommand<SetAcceptedEncodingsCommandResponse>
	{
		/// <summary>
		/// Gets or sets List of accepted content encodings.
		/// </summary>
		public string[] Encodings { get; set; }
	}
}
