using ChromeDevTools;

namespace ChromeDevTools.Protocol.Accessibility{
	/// <summary>
	/// Enum of possible property types.
	/// </summary>
	public enum AXValueType
	{
			Boolean,
			Tristate,
			BooleanOrUndefined,
			Idref,
			IdrefList,
			Integer,
			Number,
			String,
			Token,
			TokenList,
			DomRelation,
			Role,
			InternalRole,
	}
}
