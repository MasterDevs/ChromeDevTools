using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.CompositingReasons)]
	[SupportedBy("Chrome")]
	public class CompositingReasonsCommandResponse
	{
		/// <summary>
		/// Gets or sets A list of strings specifying reasons for the given layer to become composited.
		/// </summary>
		public string[] CompositingReasons { get; set; }
	}
}
