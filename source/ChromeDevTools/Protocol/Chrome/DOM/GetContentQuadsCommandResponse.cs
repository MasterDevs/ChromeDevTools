using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns quads that describe node position on the page. This method
	/// might return multiple quads for inline nodes.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetContentQuads)]
	[SupportedBy("Chrome")]
	public class GetContentQuadsCommandResponse
	{
		/// <summary>
		/// Gets or sets Quads that describe node layout relative to viewport.
		/// </summary>
		public double[][] Quads { get; set; }
	}
}
