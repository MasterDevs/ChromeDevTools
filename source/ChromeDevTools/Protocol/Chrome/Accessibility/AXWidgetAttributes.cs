using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// Attributes which apply to widgets.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXWidgetAttributes
	{
			Autocomplete,
			Haspopup,
			Level,
			Multiselectable,
			Orientation,
			Multiline,
			Readonly,
			Required,
			Valuemin,
			Valuemax,
			Valuetext,
	}
}
