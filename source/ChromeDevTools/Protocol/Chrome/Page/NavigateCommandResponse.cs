using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Navigate)]
	[SupportedBy("Chrome")]
	public class NavigateCommandResponse
	{
		/// <summary>
		/// Gets or sets Frame id that has navigated (or failed to navigate)
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Loader identifier.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets User friendly error message, present if and only if navigation has failed.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ErrorText { get; set; }
	}
}
