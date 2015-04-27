using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>
	[Command(ProtocolName.Page.Navigate)]
	public class NavigateCommand
	{
		/// <summary>
		/// Gets or sets URL to navigate the page to.
		/// </summary>
		public string Url { get; set; }
	}
}
