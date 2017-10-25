using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// Relationships between elements other than parent/child/sibling.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXRelationshipAttributes
	{
			Activedescendant,
			Controls,
			Describedby,
			Details,
			Errormessage,
			Flowto,
			Labelledby,
			Owns,
	}
}
