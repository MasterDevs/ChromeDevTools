using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Activates emulation of network conditions.
	/// </summary>
	[Command(ProtocolName.Network.EmulateNetworkConditions)]
	[SupportedBy("Chrome")]
	public class EmulateNetworkConditionsCommand: ICommand<EmulateNetworkConditionsCommandResponse>
	{
		/// <summary>
		/// Gets or sets True to emulate internet disconnection.
		/// </summary>
		public bool Offline { get; set; }
		/// <summary>
		/// Gets or sets Additional latency (ms).
		/// </summary>
		public double Latency { get; set; }
		/// <summary>
		/// Gets or sets Maximal aggregated download throughput.
		/// </summary>
		public double DownloadThroughput { get; set; }
		/// <summary>
		/// Gets or sets Maximal aggregated upload throughput.
		/// </summary>
		public double UploadThroughput { get; set; }
		/// <summary>
		/// Gets or sets Connection type if known.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ConnectionType { get; set; }
	}
}
