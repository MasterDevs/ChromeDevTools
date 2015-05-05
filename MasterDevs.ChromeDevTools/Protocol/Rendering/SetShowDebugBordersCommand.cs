using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows debug borders on layers
	/// </summary>
	[Command(ProtocolName.Rendering.SetShowDebugBorders)]
	public class SetShowDebugBordersCommand
	{
		/// <summary>
		/// Gets or sets True for showing debug borders
		/// </summary>
		public bool Show { get; set; }
	}
}
