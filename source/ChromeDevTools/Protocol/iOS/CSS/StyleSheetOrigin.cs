using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS{
	/// <summary>
	/// Stylesheet type: "user" for user stylesheets, "user-agent" for user-agent stylesheets, "inspector" for stylesheets created by the inspector (i.e. those holding the "via inspector" rules), "regular" for regular stylesheets.
	/// </summary>
	public enum StyleSheetOrigin
	{
			User,
			User_agent,
			Inspector,
			Regular,
	}
}
