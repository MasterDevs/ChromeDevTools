using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Sets whether User Verification succeeds or fails for an authenticator.
	/// The default is true.
	/// </summary>
	[Command(ProtocolName.WebAuthn.SetUserVerified)]
	[SupportedBy("Chrome")]
	public class SetUserVerifiedCommand: ICommand<SetUserVerifiedCommandResponse>
	{
		/// <summary>
		/// Gets or sets AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Gets or sets IsUserVerified
		/// </summary>
		public bool IsUserVerified { get; set; }
	}
}
