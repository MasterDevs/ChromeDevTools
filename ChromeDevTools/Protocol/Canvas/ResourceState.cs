using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Resource state.
	/// </summary>
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
		public ResourceStateDescriptor[] Descriptors { get; set; }
		/// <summary>
		/// Gets or sets Screenshot image data URL.
		/// </summary>
		public string ImageURL { get; set; }
	}
}
