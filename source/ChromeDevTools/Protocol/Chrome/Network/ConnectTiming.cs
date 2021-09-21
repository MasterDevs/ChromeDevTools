using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class ConnectTiming
	{
		/// <summary>
		/// Gets or sets Timing's requestTime is a baseline in seconds, while the other numbers are ticks in
		/// milliseconds relatively to this requestTime. Matches ResourceTiming's requestTime for
		/// the same request (but not for redirected requests).
		/// </summary>
		public double RequestTime { get; set; }
	}
}
