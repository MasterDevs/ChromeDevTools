using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get Chrome histograms.
	/// </summary>
	[Command(ProtocolName.Browser.GetHistograms)]
	[SupportedBy("Chrome")]
	public class GetHistogramsCommand: ICommand<GetHistogramsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Requested substring in name. Only histograms which have query as a
		/// substring in their name are extracted. An empty or absent query returns
		/// all histograms.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Query { get; set; }
		/// <summary>
		/// Gets or sets If true, retrieve delta since last call.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Delta { get; set; }
	}
}
