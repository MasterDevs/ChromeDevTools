using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Removes a credential from the authenticator.
	/// </summary>
	[Command(ProtocolName.WebAuthn.RemoveCredential)]
	[SupportedBy("Chrome")]
	public class RemoveCredentialCommand: ICommand<RemoveCredentialCommandResponse>
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
