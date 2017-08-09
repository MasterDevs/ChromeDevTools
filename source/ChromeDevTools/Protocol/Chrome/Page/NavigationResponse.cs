using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Proceed: allow the navigation; Cancel: cancel the navigation; CancelAndIgnore: cancels the navigation and makes the requester of the navigation acts like the request was never made.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NavigationResponse
	{
			Proceed,
			Cancel,
			CancelAndIgnore,
	}
}
