using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Loading priority of a resource request.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ResourcePriority
	{
			VeryLow,
			Low,
			Medium,
			High,
			VeryHigh,
	}
}
