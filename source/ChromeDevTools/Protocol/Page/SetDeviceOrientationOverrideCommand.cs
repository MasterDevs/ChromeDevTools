using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[Command(ProtocolName.Page.SetDeviceOrientationOverride)]
	public class SetDeviceOrientationOverrideCommand
	{
		/// <summary>
		/// Gets or sets Mock alpha
		/// </summary>
		public double Alpha { get; set; }
		/// <summary>
		/// Gets or sets Mock beta
		/// </summary>
		public double Beta { get; set; }
		/// <summary>
		/// Gets or sets Mock gamma
		/// </summary>
		public double Gamma { get; set; }
	}
}
