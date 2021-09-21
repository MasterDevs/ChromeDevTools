using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Removes a credential from the authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.RemoveCredential)]
	[SupportedBy("Chrome")]
	public class RemoveCredentialCommandResponse
	{
	}
}
