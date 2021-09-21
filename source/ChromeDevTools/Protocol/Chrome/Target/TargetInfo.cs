using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	[SupportedBy("Chrome")]
	public class TargetInfo
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Title
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or sets Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Whether the target has an attached client.
		/// </summary>
		public bool Attached { get; set; }
		/// <summary>
		/// Gets or sets Opener target Id
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OpenerId { get; set; }
		/// <summary>
		/// Gets or sets Whether the target has access to the originating window.
		/// </summary>
		public bool CanAccessOpener { get; set; }
		/// <summary>
		/// Gets or sets Frame id of originating window (is only set if target has an opener).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OpenerFrameId { get; set; }
		/// <summary>
		/// Gets or sets BrowserContextId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
