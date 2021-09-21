using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing{
	/// <summary>
	/// Data format of a trace. Can be either the legacy JSON format or the
	/// protocol buffer format. Note that the JSON format will be deprecated soon.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StreamFormat
	{
			Json,
			Proto,
	}
}
