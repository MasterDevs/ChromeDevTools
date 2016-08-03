using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Search result for resource.
	/// </summary>
	[SupportedBy("iOS")]
	public class SearchResult
	{
		/// <summary>
		/// Gets or sets Resource URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Resource frame id.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Number of matches in the resource content.
		/// </summary>
		public double MatchesCount { get; set; }
	}
}
