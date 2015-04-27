using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// A single computed AX property.
	/// </summary>
	public class AXValue
	{
		/// <summary>
		/// Gets or sets The type of this value.
		/// </summary>
		public AXValueType Type { get; set; }
		/// <summary>
		/// Gets or sets The computed value of this property.
		/// </summary>
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets The related node value, if any.
		/// </summary>
		public AXRelatedNode RelatedNodeValue { get; set; }
		/// <summary>
		/// Gets or sets Multiple relted nodes, if applicable.
		/// </summary>
		public AXRelatedNode[] RelatedNodeArrayValue { get; set; }
		/// <summary>
		/// Gets or sets The sources which contributed to the computation of this property.
		/// </summary>
		public AXPropertySource[] Sources { get; set; }
	}
}
