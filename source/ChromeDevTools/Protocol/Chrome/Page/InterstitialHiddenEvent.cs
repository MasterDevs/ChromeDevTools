using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when interstitial page was hidden
	/// </summary>
	[Event(ProtocolName.Page.InterstitialHidden)]
	[SupportedBy("Chrome")]
	public class InterstitialHiddenEvent
	{
	}
}
