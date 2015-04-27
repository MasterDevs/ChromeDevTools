using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// 
	/// </summary>
	public class AXRelatedNode
	{
		/// <summary>
		/// Gets or sets The IDRef value provided, if any.
		/// </summary>
		public string Idref { get; set; }
		/// <summary>
		/// Gets or sets The BackendNodeId of the related node.
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
