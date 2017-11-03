using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Returns usage and quota in bytes.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.GetUsageAndQuota)]
	[SupportedBy("Chrome")]
	public class GetUsageAndQuotaCommandResponse
	{
		/// <summary>
		/// Gets or sets Storage usage (bytes).
		/// </summary>
		public double Usage { get; set; }
		/// <summary>
		/// Gets or sets Storage quota (bytes).
		/// </summary>
		public double Quota { get; set; }
		/// <summary>
		/// Gets or sets Storage usage per type (bytes).
		/// </summary>
		public UsageForType[] UsageBreakdown { get; set; }
	}
}
