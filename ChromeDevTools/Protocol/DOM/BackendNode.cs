using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Backend node with a friendly name.
	/// </summary>
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
