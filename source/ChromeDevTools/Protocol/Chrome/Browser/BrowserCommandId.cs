using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser{
	/// <summary>
	/// Browser command ids used by executeBrowserCommand.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BrowserCommandId
	{
			OpenTabSearch,
			CloseTabSearch,
	}
}
