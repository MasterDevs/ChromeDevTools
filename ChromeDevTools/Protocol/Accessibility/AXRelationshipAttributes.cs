using ChromeDevTools;

namespace ChromeDevTools.Protocol.Accessibility{
	/// <summary>
	/// Relationships between elements other than parent/child/sibling.
	/// </summary>
	public enum AXRelationshipAttributes
	{
			Activedescendant,
			Flowto,
			Controls,
			Describedby,
			Labelledby,
			Owns,
	}
}
