using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Removes all Trust Tokens issued by the provided issuerOrigin.
	/// Leaves other stored data, including the issuer's Redemption Records, intact.
	/// </summary>
	[Command(ProtocolName.Storage.ClearTrustTokens)]
	[SupportedBy("Chrome")]
	public class ClearTrustTokensCommand: ICommand<ClearTrustTokensCommandResponse>
	{
		/// <summary>
		/// Gets or sets IssuerOrigin
		/// </summary>
		public string IssuerOrigin { get; set; }
	}
}
