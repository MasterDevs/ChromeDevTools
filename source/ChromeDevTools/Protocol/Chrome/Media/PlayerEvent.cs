using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Corresponds to kMediaEventTriggered
	/// </summary>
	[SupportedBy("Chrome")]
	public class PlayerEvent
	{
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public string Value { get; set; }
	}
}
