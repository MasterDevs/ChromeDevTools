using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// Enum of possible property types.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXValueType
	{
			Boolean,
			Tristate,
			BooleanOrUndefined,
			Idref,
			IdrefList,
			Integer,
			Node,
			NodeList,
			Number,
			String,
			ComputedString,
			Token,
			TokenList,
			DomRelation,
			Role,
			InternalRole,
			ValueUndefined,
	}
}
