using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>
	[Command(ProtocolName.Page.Navigate)]
	[SupportedBy("Chrome")]
	public class NavigateCommand: ICommand<NavigateCommandResponse>
	{
		/// <summary>
		/// Gets or sets URL to navigate the page to.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Referrer URL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Referrer { get; set; }
		/// <summary>
		/// Gets or sets Intended transition type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TransitionType { get; set; }
	}
}
