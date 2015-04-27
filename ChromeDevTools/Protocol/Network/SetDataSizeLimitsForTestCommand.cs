using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// For testing.
	/// </summary>
	[Command(ProtocolName.Network.SetDataSizeLimitsForTest)]
	public class SetDataSizeLimitsForTestCommand
	{
		/// <summary>
		/// Gets or sets Maximum total buffer size.
		/// </summary>
		public long MaxTotalSize { get; set; }
		/// <summary>
		/// Gets or sets Maximum per-resource size.
		/// </summary>
		public long MaxResourceSize { get; set; }
	}
}
