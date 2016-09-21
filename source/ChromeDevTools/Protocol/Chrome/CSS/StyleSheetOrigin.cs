using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS{
	/// <summary>
	/// Stylesheet type: "injected" for stylesheets injected via extension, "user-agent" for user-agent stylesheets, "inspector" for stylesheets created by the inspector (i.e. those holding the "via inspector" rules), "regular" for regular stylesheets.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StyleSheetOrigin
	{
			Injected,
			[EnumMember(Value = "user-agent")]
			User_agent,
			Inspector,
			Regular,
	}
}
