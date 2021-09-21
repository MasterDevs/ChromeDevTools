using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Sets whether tests of user presence will succeed immediately (if true) or fail to resolve (if false) for an authenticator.
	/// The default is true.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.SetAutomaticPresenceSimulation)]
	[SupportedBy("Chrome")]
	public class SetAutomaticPresenceSimulationCommandResponse
	{
	}
}
