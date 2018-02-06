using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Blocks URLs from loading.
	/// </summary>
	[Command(ProtocolName.Network.SetBlockedURLs)]
	[SupportedBy("Chrome")]
	public class SetBlockedURLsCommand: ICommand<SetBlockedURLsCommandResponse>
	{
		/// <summary>
		/// Gets or sets URL patterns to block. Wildcards ('*') are allowed.
		/// </summary>
		public string[] Urls { get; set; }
	}
}
