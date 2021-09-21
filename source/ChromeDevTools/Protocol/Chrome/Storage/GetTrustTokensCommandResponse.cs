using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Returns the number of stored Trust Tokens per issuer for the
	/// current browsing context.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.GetTrustTokens)]
	[SupportedBy("Chrome")]
	public class GetTrustTokensCommandResponse
	{
		/// <summary>
		/// Gets or sets Tokens
		/// </summary>
		public TrustTokens[] Tokens { get; set; }
	}
}
