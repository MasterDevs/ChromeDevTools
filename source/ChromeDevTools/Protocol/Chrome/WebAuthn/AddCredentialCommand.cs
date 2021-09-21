using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Adds the credential to the specified authenticator.
	/// </summary>
	[Command(ProtocolName.WebAuthn.AddCredential)]
	[SupportedBy("Chrome")]
	public class AddCredentialCommand: ICommand<AddCredentialCommandResponse>
	{
		/// <summary>
		/// Gets or sets AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Gets or sets Credential
		/// </summary>
		public Credential Credential { get; set; }
	}
}
