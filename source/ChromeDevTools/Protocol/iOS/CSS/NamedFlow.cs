using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// This object represents a Named Flow.
	/// </summary>
	[SupportedBy("iOS")]
	public class NamedFlow
	{
		/// <summary>
		/// Gets or sets The document node id.
		/// </summary>
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Named Flow identifier.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The "overset" attribute of a Named Flow.
		/// </summary>
		public bool Overset { get; set; }
		/// <summary>
		/// Gets or sets An array of nodes that flow into the Named Flow.
		/// </summary>
		public long[] Content { get; set; }
		/// <summary>
		/// Gets or sets An array of regions associated with the Named Flow.
		/// </summary>
		public Region[] Regions { get; set; }
	}
}
