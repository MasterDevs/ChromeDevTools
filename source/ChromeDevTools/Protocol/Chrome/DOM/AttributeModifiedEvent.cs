using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Fired when <code>Element</code>'s attribute is modified.
	/// </summary>
	[Event(ProtocolName.DOM.AttributeModified)]
	[SupportedBy("Chrome")]
	public class AttributeModifiedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
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
