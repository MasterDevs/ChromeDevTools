using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	/// <summary>
	/// Detailed application cache information.
	/// </summary>
	[SupportedBy("iOS")]
	public class ApplicationCache
	{
		/// <summary>
		/// Gets or sets Manifest URL.
		/// </summary>
		public string ManifestURL { get; set; }
		/// <summary>
		/// Gets or sets Application cache size.
		/// </summary>
		public double Size { get; set; }
		/// <summary>
		/// Gets or sets Application cache creation time.
		/// </summary>
		public double CreationTime { get; set; }
		/// <summary>
		/// Gets or sets Application cache update time.
		/// </summary>
		public double UpdateTime { get; set; }
		/// <summary>
		/// Gets or sets Application cache resources.
		/// </summary>
		public ApplicationCacheResource[] Resources { get; set; }
	}
}
