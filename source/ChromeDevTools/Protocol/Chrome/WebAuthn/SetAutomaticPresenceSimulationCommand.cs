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
	[Command(ProtocolName.WebAuthn.SetAutomaticPresenceSimulation)]
	[SupportedBy("Chrome")]
	public class SetAutomaticPresenceSimulationCommand: ICommand<SetAutomaticPresenceSimulationCommandResponse>
	{
		/// <summary>
		/// Gets or sets AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Gets or sets Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
