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
	[Command(ProtocolName.WebAuthn.GetCredential)]
	[SupportedBy("Chrome")]
	public class GetCredentialCommand: ICommand<GetCredentialCommandResponse>
	{
		/// <summary>
		/// Gets or sets AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Gets or sets CredentialId
		/// </summary>
		public string CredentialId { get; set; }
	}
}
