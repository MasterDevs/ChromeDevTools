using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// Attributes which apply to nodes in live regions.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXLiveRegionAttributes
	{
			Live,
			Atomic,
			Relevant,
			Root,
	}
}
