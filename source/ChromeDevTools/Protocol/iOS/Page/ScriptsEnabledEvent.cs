using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Fired when the JavaScript is enabled/disabled on the page
	/// </summary>
	[Event(ProtocolName.Page.ScriptsEnabled)]
	[SupportedBy("iOS")]
	public class ScriptsEnabledEvent
	{
		/// <summary>
		/// Gets or sets Whether script execution is enabled or disabled on the page.
		/// </summary>
		public bool IsEnabled { get; set; }
	}
}
