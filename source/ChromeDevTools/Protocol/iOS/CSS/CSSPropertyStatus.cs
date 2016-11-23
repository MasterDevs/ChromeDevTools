using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS{
	/// <summary>
	/// The property status: "active" if the property is effective in the style, "inactive" if the property is overridden by a same-named property in this style later on, "disabled" if the property is disabled by the user, "style" (implied if absent) if the property is reported by the browser rather than by the CSS source parser.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CSSPropertyStatus
	{
			Active,
			Inactive,
			Disabled,
			Style,
	}
}
