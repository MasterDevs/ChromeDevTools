using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when interstitial page was shown
	/// </summary>
	[Event(ProtocolName.Page.InterstitialShown)]
	[SupportedBy("Chrome")]
	public class InterstitialShownEvent
	{
	}
}
