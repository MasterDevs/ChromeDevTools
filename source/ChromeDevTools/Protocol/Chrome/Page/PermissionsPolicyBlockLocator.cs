using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class PermissionsPolicyBlockLocator
	{
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets BlockReason
		/// </summary>
		public PermissionsPolicyBlockReason BlockReason { get; set; }
	}
}
