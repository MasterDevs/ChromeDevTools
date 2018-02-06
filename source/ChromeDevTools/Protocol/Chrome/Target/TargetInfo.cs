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
	}
}
