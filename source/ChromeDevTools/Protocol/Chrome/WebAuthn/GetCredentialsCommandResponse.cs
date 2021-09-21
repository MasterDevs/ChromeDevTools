using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Returns all the credentials stored in the given virtual authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.GetCredentials)]
	[SupportedBy("Chrome")]
	public class GetCredentialsCommandResponse
	{
		/// <summary>
		/// Gets or sets Credentials
		/// </summary>
		public Credential[] Credentials { get; set; }
	}
}
