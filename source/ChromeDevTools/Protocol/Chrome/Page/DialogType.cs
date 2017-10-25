using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Javascript dialog type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DialogType
	{
			Alert,
			Confirm,
			Prompt,
			Beforeunload,
	}
}
