using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Removes the given authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.RemoveVirtualAuthenticator)]
	[SupportedBy("Chrome")]
	public class RemoveVirtualAuthenticatorCommandResponse
	{
	}
}
