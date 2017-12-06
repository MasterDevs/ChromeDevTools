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
		/// Gets or sets The initial URL the page will be navigated to.
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
		/// Gets or sets The browser context to create the page in (headless chrome only).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
