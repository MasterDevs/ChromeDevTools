using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM{
	/// <summary>
	/// Document compatibility mode.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CompatibilityMode
	{
			QuirksMode,
			LimitedQuirksMode,
			NoQuirksMode,
	}
}
