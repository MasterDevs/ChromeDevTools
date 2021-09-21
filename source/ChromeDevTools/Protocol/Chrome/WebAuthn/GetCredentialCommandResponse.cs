using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Returns a single credential stored in the given virtual authenticator that
	/// matches the credential ID.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.GetCredential)]
	[SupportedBy("Chrome")]
	public class GetCredentialCommandResponse
	{
		/// <summary>
		/// Gets or sets Credential
		/// </summary>
		public Credential Credential { get; set; }
	}
}
