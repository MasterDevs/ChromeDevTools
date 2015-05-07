using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend enables continuous painting
	/// </summary>
	[Command(ProtocolName.Rendering.SetContinuousPaintingEnabled)]
	public class SetContinuousPaintingEnabledCommand
	{
		/// <summary>
		/// Gets or sets True for enabling cointinuous painting
		/// </summary>
		public bool Enabled { get; set; }
	}
}
