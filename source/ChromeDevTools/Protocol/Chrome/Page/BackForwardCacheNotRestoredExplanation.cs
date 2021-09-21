using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class BackForwardCacheNotRestoredExplanation
	{
		/// <summary>
		/// Gets or sets Type of the reason
		/// </summary>
		public BackForwardCacheNotRestoredReasonType Type { get; set; }
		/// <summary>
		/// Gets or sets Not restored reason
		/// </summary>
		public BackForwardCacheNotRestoredReason Reason { get; set; }
	}
}
