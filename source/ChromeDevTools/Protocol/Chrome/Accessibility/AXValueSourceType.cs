using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// Enum of possible property sources.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXValueSourceType
	{
			Attribute,
			Implicit,
			Style,
			Contents,
			Placeholder,
			RelatedElement,
	}
}
