using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
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
	}
}
