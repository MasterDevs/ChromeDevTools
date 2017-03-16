using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	/// <summary>
	/// Resource state.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ResourceState
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets Describes current <code>Resource</code> state.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ResourceStateDescriptor[] Descriptors { get; set; }
		/// <summary>
		/// Gets or sets Screenshot image data URL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ImageURL { get; set; }
	}
}
