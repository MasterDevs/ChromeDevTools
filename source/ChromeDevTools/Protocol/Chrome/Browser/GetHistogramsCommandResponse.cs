using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get Chrome histograms.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.GetHistograms)]
	[SupportedBy("Chrome")]
	public class GetHistogramsCommandResponse
	{
		/// <summary>
		/// Gets or sets Histograms.
		/// </summary>
		public Histogram[] Histograms { get; set; }
	}
}
