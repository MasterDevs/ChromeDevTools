using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Creates a new page.
	/// </summary>
	[Command(ProtocolName.Target.CreateTarget)]
	[SupportedBy("Chrome")]
	public class CreateTargetCommand: ICommand<CreateTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets The initial URL the page will be navigated to. An empty string indicates about:blank.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Frame width in DIP (headless chrome only).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Width { get; set; }
		/// <summary>
		/// Gets or sets Frame height in DIP (headless chrome only).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Height { get; set; }
		/// <summary>
		/// Gets or sets The browser context to create the page in.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
		/// <summary>
		/// Gets or sets Whether BeginFrames for this target will be controlled via DevTools (headless chrome only,
		/// not supported on MacOS yet, false by default).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EnableBeginFrameControl { get; set; }
		/// <summary>
		/// Gets or sets Whether to create a new Window or Tab (chrome-only, false by default).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? NewWindow { get; set; }
		/// <summary>
		/// Gets or sets Whether to create the target in background or foreground (chrome-only,
		/// false by default).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Background { get; set; }
	}
}
