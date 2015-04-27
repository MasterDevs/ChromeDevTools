using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Sets a specified page scale factor.
	/// </summary>
	[Command(ProtocolName.Emulation.SetPageScaleFactor)]
	public class SetPageScaleFactorCommand
	{
		/// <summary>
		/// Gets or sets Page scale factor.
		/// </summary>
		public double PageScaleFactor { get; set; }
	}
}
