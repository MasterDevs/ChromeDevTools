using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio{
	/// <summary>
	/// Enum of AudioParam::AutomationRate from the spec
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutomationRate
	{
			[EnumMember(Value = "a-rate")]
			A_rate,
			[EnumMember(Value = "k-rate")]
			K_rate,
	}
}
