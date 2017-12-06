using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Starts sending each frame using the <code>screencastFrame</code> event.
	/// </summary>
	[Command(ProtocolName.Page.StartScreencast)]
	[SupportedBy("Chrome")]
	public class StartScreencastCommand: ICommand<StartScreencastCommandResponse>
	{
		/// <summary>
		/// Gets or sets Image compression format.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Format { get; set; }
		/// <summary>
		/// Gets or sets Compression quality from range [0..100].
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Quality { get; set; }
		/// <summary>
		/// Gets or sets Maximum screenshot width.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxWidth { get; set; }
		/// <summary>
		/// Gets or sets Maximum screenshot height.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxHeight { get; set; }
		/// <summary>
		/// Gets or sets Send every n-th frame.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? EveryNthFrame { get; set; }
	}
}
