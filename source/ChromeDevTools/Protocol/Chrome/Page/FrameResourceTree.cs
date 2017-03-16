using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Information about the Frame hierarchy along with their cached resources.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FrameResourceTree
	{
		/// <summary>
		/// Gets or sets Frame information for this tree item.
		/// </summary>
		public Frame Frame { get; set; }
		/// <summary>
		/// Gets or sets Child frames.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FrameResourceTree[] ChildFrames { get; set; }
		public class ResourcesArray
		{
		/// <summary>
		/// Gets or sets Resource URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Type of this resource.
		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets Resource mimeType as determined by the browser.
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets True if the resource failed to load.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Failed { get; set; }
		/// <summary>
		/// Gets or sets True if the resource was canceled during loading.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Canceled { get; set; }
		}

		/// <summary>
		/// Gets or sets Information about frame resources.
		/// </summary>
		public ResourcesArray[] Resources { get; set; }
	}
}
