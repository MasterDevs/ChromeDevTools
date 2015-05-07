using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>
	[Command(ProtocolName.Rendering.SetShowFPSCounter)]
	public class SetShowFPSCounterCommand
	{
		/// <summary>
		/// Gets or sets True for showing the FPS counter
		/// </summary>
		public bool Show { get; set; }
	}
}
