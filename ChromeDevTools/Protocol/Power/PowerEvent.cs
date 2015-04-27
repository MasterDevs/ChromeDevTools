using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// PowerEvent item
	/// </summary>
	public class PowerEvent
	{
		/// <summary>
		/// Gets or sets Power Event Type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Power Event Time, in milliseconds.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Power Event Value.
		/// </summary>
		public double Value { get; set; }
	}
}
