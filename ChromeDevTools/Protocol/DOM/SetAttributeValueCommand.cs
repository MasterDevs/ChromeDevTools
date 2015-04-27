using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets attribute for an element with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetAttributeValue)]
	public class SetAttributeValueCommand
	{
		/// <summary>
		/// Gets or sets Id of the element to set attribute for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Attribute name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Attribute value.
		/// </summary>
		public string Value { get; set; }
	}
}
