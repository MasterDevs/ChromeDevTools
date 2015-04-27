using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
	/// </summary>
	[Command(ProtocolName.Emulation.SetGeolocationOverride)]
	public class SetGeolocationOverrideCommand
	{
		/// <summary>
		/// Gets or sets Mock latitude
		/// </summary>
		public double Latitude { get; set; }
		/// <summary>
		/// Gets or sets Mock longitude
		/// </summary>
		public double Longitude { get; set; }
		/// <summary>
		/// Gets or sets Mock accuracy
		/// </summary>
		public double Accuracy { get; set; }
	}
}
