using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns the JavaScript heap usage.
	/// It is the total usage of the corresponding isolate not scoped to a particular Runtime.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetHeapUsage)]
	[SupportedBy("Chrome")]
	public class GetHeapUsageCommandResponse
	{
		/// <summary>
		/// Gets or sets Used heap size in bytes.
		/// </summary>
		public double UsedSize { get; set; }
		/// <summary>
		/// Gets or sets Allocated heap size in bytes.
		/// </summary>
		public double TotalSize { get; set; }
	}
}
