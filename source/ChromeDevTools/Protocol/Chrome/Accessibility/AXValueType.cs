using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
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
