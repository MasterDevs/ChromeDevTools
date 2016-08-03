using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Backend node with a friendly name.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BackendNode
	{
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeType.
		/// </summary>
		public long NodeType { get; set; }
		/// <summary>
		/// Gets or sets <code>Node</code>'s nodeName.
		/// </summary>
		public string NodeName { get; set; }
		/// <summary>
		/// Gets or sets BackendNodeId
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
