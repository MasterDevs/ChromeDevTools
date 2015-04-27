using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns content of the given resource.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceContent)]
	public class GetResourceContentCommand
	{
		/// <summary>
		/// Gets or sets Frame id to get resource for.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets URL of the resource to get content for.
		/// </summary>
		public string Url { get; set; }
	}
}
