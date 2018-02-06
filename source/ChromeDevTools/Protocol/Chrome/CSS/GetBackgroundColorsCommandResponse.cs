using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	[CommandResponse(ProtocolName.CSS.GetBackgroundColors)]
	[SupportedBy("Chrome")]
	public class GetBackgroundColorsCommandResponse
	{
		/// <summary>
		/// Gets or sets The range of background colors behind this element, if it contains any visible text. If no visible text is present, this will be undefined. In the case of a flat background color, this will consist of simply that color. In the case of a gradient, this will consist of each of the color stops. For anything more complicated, this will be an empty array. Images will be ignored (as if the image had failed to load).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] BackgroundColors { get; set; }
		/// <summary>
		/// Gets or sets The computed font size for this node, as a CSS computed value string (e.g. '12px').
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ComputedFontSize { get; set; }
		/// <summary>
		/// Gets or sets The computed font weight for this node, as a CSS computed value string (e.g. 'normal' or '100').
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ComputedFontWeight { get; set; }
		/// <summary>
		/// Gets or sets The computed font size for the document body, as a computed CSS value string (e.g. '16px').
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ComputedBodyFontSize { get; set; }
	}
}
