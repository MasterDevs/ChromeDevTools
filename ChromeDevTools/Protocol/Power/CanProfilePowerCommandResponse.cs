using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Tells whether power profiling is supported.
	/// </summary>
	[CommandResponse(ProtocolName.Power.CanProfilePower)]
	public class CanProfilePowerCommandResponse
	{
		/// <summary>
		/// Gets or sets True if power profiling is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}
