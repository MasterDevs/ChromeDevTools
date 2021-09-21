using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Indicates whether the frame is cross-origin isolated and why it is the case.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrossOriginIsolatedContextType
	{
			Isolated,
			NotIsolated,
			NotIsolatedFeatureDisabled,
	}
}
