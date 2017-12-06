using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightFrame)]
	[SupportedBy("iOS")]
	public class HighlightFrameCommand: ICommand<HighlightFrameCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the frame to highlight.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor ContentColor { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight outline color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor ContentOutlineColor { get; set; }
	}
}
