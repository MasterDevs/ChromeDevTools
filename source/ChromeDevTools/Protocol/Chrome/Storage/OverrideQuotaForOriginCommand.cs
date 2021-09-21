using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Override quota for the specified origin
	/// </summary>
	[Command(ProtocolName.Storage.OverrideQuotaForOrigin)]
	[SupportedBy("Chrome")]
	public class OverrideQuotaForOriginCommand: ICommand<OverrideQuotaForOriginCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets The quota size (in bytes) to override the original quota with.
		/// If this is called multiple times, the overridden quota will be equal to
		/// the quotaSize provided in the final call. If this is called without
		/// specifying a quotaSize, the quota will be reset to the default value for
		/// the specified origin. If this is called multiple times with different
		/// origins, the override will be maintained for each origin until it is
		/// disabled (called without a quotaSize).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double QuotaSize { get; set; }
	}
}
