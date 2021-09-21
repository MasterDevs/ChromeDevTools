using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation{
	/// <summary>
	/// Enum of image types that can be disabled.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DisabledImageType
	{
			Avif,
			Jxl,
			Webp,
	}
}
