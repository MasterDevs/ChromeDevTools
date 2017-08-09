using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime{
	/// <summary>
	/// Primitive value which cannot be JSON-stringified.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnserializableValue
	{
			Infinity,
			NaN,
			[EnumMember(Value = "-Infinity")]
			_Infinity,
			[EnumMember(Value = "-0")]
			_0,
	}
}
