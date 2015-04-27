using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetMediaQueries)]
	public class GetMediaQueriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Medias
		/// </summary>
		public CSSMedia[] Medias { get; set; }
	}
}
