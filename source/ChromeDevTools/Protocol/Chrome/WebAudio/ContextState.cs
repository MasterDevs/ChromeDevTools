using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio{
	/// <summary>
	/// Enum of AudioContextState from the spec
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContextState
	{
			Suspended,
			Running,
			Closed,
	}
}
