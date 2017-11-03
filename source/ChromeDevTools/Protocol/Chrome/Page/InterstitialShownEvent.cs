using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

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
