using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Enable the WebAuthn domain and start intercepting credential storage and
	/// retrieval with a virtual authenticator.
	/// </summary>
	[Command(ProtocolName.WebAuthn.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
