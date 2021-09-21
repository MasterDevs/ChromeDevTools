using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Adds the credential to the specified authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.AddCredential)]
	[SupportedBy("Chrome")]
	public class AddCredentialCommandResponse
	{
	}
}
