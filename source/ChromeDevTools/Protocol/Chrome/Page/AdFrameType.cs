using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Indicates whether a frame has been identified as an ad.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AdFrameType
	{
			None,
			Child,
			Root,
	}
}
