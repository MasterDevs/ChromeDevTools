using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReasonsForCompositingLayer)]
	[SupportedBy("iOS")]
	public class ReasonsForCompositingLayerCommandResponse
	{
		/// <summary>
		/// Gets or sets An object containing the reasons why the layer was composited as properties.
		/// </summary>
		public CompositingReasons CompositingReasons { get; set; }
	}
}
