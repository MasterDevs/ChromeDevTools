using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>
	[Command(ProtocolName.Page.Navigate)]
	[SupportedBy("iOS")]
	public class NavigateCommand: ICommand<NavigateCommandResponse>
	{
		/// <summary>
		/// Gets or sets URL to navigate the page to.
		/// </summary>
		public string Url { get; set; }
	}
}
