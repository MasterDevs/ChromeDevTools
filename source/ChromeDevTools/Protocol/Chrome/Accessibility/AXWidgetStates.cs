using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// States which apply to widgets.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXWidgetStates
	{
			Checked,
			Expanded,
			Modal,
			Pressed,
			Selected,
	}
}
