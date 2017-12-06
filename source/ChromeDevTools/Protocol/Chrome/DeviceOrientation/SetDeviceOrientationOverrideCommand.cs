using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceOrientation
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[Command(ProtocolName.DeviceOrientation.SetDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommand: ICommand<SetDeviceOrientationOverrideCommandResponse>
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
