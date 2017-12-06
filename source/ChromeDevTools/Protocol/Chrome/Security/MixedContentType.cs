using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security{
	/// <summary>
	/// A description of mixed content (HTTP resources on HTTPS pages), as defined by https://www.w3.org/TR/mixed-content/#categories
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MixedContentType
	{
			Blockable,
			[EnumMember(Value = "optionally-blockable")]
			Optionally_blockable,
			None,
	}
}
