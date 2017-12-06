using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Returns usage and quota in bytes.
	/// </summary>
	[Command(ProtocolName.Storage.GetUsageAndQuota)]
	[SupportedBy("Chrome")]
	public class GetUsageAndQuotaCommand: ICommand<GetUsageAndQuotaCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
