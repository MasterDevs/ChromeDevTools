using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// The reason why request was blocked.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BlockedReason
	{
			Csp,
			[EnumMember(Value = "mixed-content")]
			Mixed_content,
			Origin,
			Inspector,
			[EnumMember(Value = "subresource-filter")]
			Subresource_filter,
			Other,
	}
}
