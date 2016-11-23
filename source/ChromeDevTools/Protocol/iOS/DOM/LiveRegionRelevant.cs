using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM{
	/// <summary>
	/// Token values of @aria-relevant attribute.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LiveRegionRelevant
	{
			Additions,
			Removals,
			Text,
	}
}
