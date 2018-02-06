using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// States which apply to every AX node.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXGlobalStates
	{
			Busy,
			Disabled,
			Hidden,
			HiddenRoot,
			Invalid,
			Keyshortcuts,
			Roledescription,
	}
}
