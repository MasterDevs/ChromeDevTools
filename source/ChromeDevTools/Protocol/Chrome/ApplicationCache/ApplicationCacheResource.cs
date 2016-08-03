using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ApplicationCache
{
	/// <summary>
	/// Detailed application cache resource information.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ApplicationCacheResource
	{
		/// <summary>
		/// Gets or sets Resource url.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Resource size.
		/// </summary>
		public long Size { get; set; }
		/// <summary>
		/// Gets or sets Resource type.
		/// </summary>
		public string Type { get; set; }
	}
}
