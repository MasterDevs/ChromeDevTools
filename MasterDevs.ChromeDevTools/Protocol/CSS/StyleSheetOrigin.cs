using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS{
	/// <summary>
	/// Stylesheet type: "injected" for stylesheets injected via extension, "user-agent" for user-agent stylesheets, "inspector" for stylesheets created by the inspector (i.e. those holding the "via inspector" rules), "regular" for regular stylesheets.
	/// </summary>
	public enum StyleSheetOrigin
	{
			Injected,
			User_agent,
			Inspector,
			Regular,
	}
}
