using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Highlights owner element of all frames detected to be ads.
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowAdHighlights)]
	[SupportedBy("Chrome")]
	public class SetShowAdHighlightsCommand: ICommand<SetShowAdHighlightsCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing ad highlights
		/// </summary>
		public bool Show { get; set; }
	}
}
